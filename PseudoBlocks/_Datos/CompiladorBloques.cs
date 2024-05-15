using PseudoBlocks.Controlador;
using PseudoBlocks.Vista.Controles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks._Datos
{
	class CompiladorBloques
	{
		public static string Error { get; private set; } = string.Empty;
		private static int contadorIds = 0;

		public static bool GenerarCodigo(List<DatosBloque> bloques)
		{
			string rutaControlador = @".\PseudoPlayer\_Controlador\ControlJuego.cs";

			if (!File.Exists(rutaControlador))
			{
				Error = "No se encontró el archivo de controlador.";
				return false;
			}

			List<string> codigo = new List<string>();

			try
			{
				codigo = File.ReadAllLines(rutaControlador).ToList();
			}
			catch 
			{
				Error = "Error al leer el archivo de controlador.";
				return false; 
			}

			int indiceInicio = codigo.FindIndex(x => x.Contains("<INICIO>"));

			foreach (DatosBloque bloque in bloques)
			{
				if (bloque.Tipo == "event_onload" || 
					bloque.Tipo == "logic_repeatAlways" || 
					bloque.Tipo == "event_onpress")
				{
					codigo.Insert(++indiceInicio, "			" + ObtenerCodigo(bloque));
				}
			}

			try
			{
				File.WriteAllLines(rutaControlador, codigo);
			}
			catch 
			{ 
				Error = "Error al escribir el archivo de controlador.";
				return false; 
			}

			return true;
		}

		public static string ObtenerCodigo(DatosBloque datosBloque)
		{
			StringBuilder codigo = new StringBuilder();
			switch (datosBloque.Tipo)
			{
				case "move_right":
					codigo.Append("personaje.MoverDerecha();");
					break;
				case "move_left":
					codigo.Append("personaje.MoverIzquierda();");
					break;
				case "move_up":
					codigo.Append("personaje.MoverArriba();");
					break;
				case "move_down":
					codigo.Append("personaje.MoverAbajo();");
					break;
				case "move_to":
					codigo.AppendFormat("personaje.MoverA({0}, {1});", ((DatosBloqueXY)datosBloque).X, ((DatosBloqueXY)datosBloque).Y);
					break;
				case "change_size":
					codigo.Append("playerWindow.Size = new Size(" + ((DatosBloqueXY)datosBloque).X + ", " + ((DatosBloqueXY)datosBloque).Y + ");");
					break;
				case "change_character":
					codigo.Append("personaje.CambiarPersonaje(Image.FromFile(@\"" + ((DatosBloqueImagen)datosBloque).Imagen + "\"));");
					break;
				case "change_background":
					codigo.Append("playerWindow.CambiarFondo(Image.FromFile(@\"" + ((DatosBloqueImagen)datosBloque).Imagen + "\"));");
					break;
				case "sound_play":
					codigo.Append("Task.Run(() => { using (var audioFile = new AudioFileReader(@\"" + ((DatosBloqueAudio)datosBloque).Audio + "\")) using (var outputDevice = new WaveOutEvent()) { outputDevice.Init(audioFile); outputDevice.Play(); while (outputDevice.PlaybackState == PlaybackState.Playing) { Task.Delay(100).Wait(); } } });");
					break;
				case "sound_playLoop":
					codigo.Append("Task.Run(() => { using (var audioFile = new AudioFileReader(@\"" + ((DatosBloqueAudio)datosBloque).Audio + "\")) using (var outputDevice = new WaveOutEvent()) { outputDevice.Init(audioFile); outputDevice.Play(); while (true) { Task.Delay(100).Wait(); } } });");
					break;
				case "logic_wait":
					codigo.Append("Task.Delay(" + ((DatosBloqueNumerico)datosBloque).Valor + ").Wait();");
					break;
				case "logic_stopRepeating":
					codigo.Append("break;");
					break;
				case "logic_repeat":
					contadorIds++;
					codigo.Append($"for(int i{contadorIds} = 0; i{contadorIds} < {((DatosBloqueRepetir)datosBloque).Repeticiones}; i{contadorIds}++) {{");
					foreach (DatosBloque bloque in ((DatosBloqueRepetir)datosBloque).Bloques)
					{
						codigo.Append(ObtenerCodigo(bloque));
					}
					codigo.Append("}");
					break;
				case "event_onload":
					foreach (DatosBloque bloque in ((DatosBloquePanel)datosBloque).Bloques)
					{
						codigo.Append(ObtenerCodigo(bloque));
					}
					break;
				case "event_onpress":
					var tecla = ((DatosBloqueHotkey)datosBloque).Tecla;
					codigo.Append("Task.Run(() => { while (true) { if (teclasPulsadas.Contains(Keys." + tecla + ")) {");
					foreach (DatosBloque bloque in ((DatosBloqueHotkey)datosBloque).Bloques)
					{
						codigo.Append(ObtenerCodigo(bloque));
					}
					codigo.Append("} Task.Delay(1).Wait(); }});");
					break;
			}
			return codigo.ToString();
		}


		public static bool ExportarProyecto(List<DatosBloque> datos)
		{
			Process.GetProcessesByName("PseudoPlayer").ToList().ForEach(p => p.Kill());

			if (!ExtraerProyecto())
			{
				Error = "Error al extraer el proyecto.";
				return false;
			}

			string rutaProyecto = @".\PseudoPlayer\PseudoPlayer.csproj";

			if (!File.Exists(rutaProyecto))
			{
				Error = "No se ha podido encontrar el archivo de proyecto.";
				return false;
			}

			if (!GenerarCodigo(datos))
			{
				Error = "Error al generar el código.";
				return false;
			}

			if (!CompilarProyecto(rutaProyecto))
			{
				Error = "Error al compilar el proyecto.";
				return false;
			}

			if (!LimpiarCompilacion())
			{
				return false;
			}

			return true;
		}

		public static bool ExtraerProyecto()
		{
			byte[] zipFileBytes = Properties.Resources.PseudoPlayer;

			if (File.Exists("PseudoPlayer.zip"))
			{
				try { File.Delete("PseudoPlayer.zip"); } catch { }
			}

			File.WriteAllBytes("PseudoPlayer.zip", zipFileBytes);

			if (!File.Exists("PseudoPlayer.zip")) return false;

			try
			{
				using (ZipArchive za = ZipFile.OpenRead("PseudoPlayer.zip"))
				{
					za.ExtractToDirectory("PseudoPlayer");
					za.Dispose();
				}
			}
			catch { return false; }


			return true;
		}

		public static bool CompilarProyecto(string ruta)
		{
			bool compilado = false;
			try
			{
				var proc = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = @"C:\Windows\System32\cmd.exe",
						Arguments = $"/c dotnet build {ruta} --configuration Release --property WarningLevel=1 > salida_compilacion.txt",
						UseShellExecute = false,
						CreateNoWindow = true,
						WorkingDirectory = Application.StartupPath,
						RedirectStandardOutput = true,
					}
				};

				proc.Start();
				proc.WaitForExit();

				if (File.Exists("salida_compilacion.txt") 
					&& File.ReadAllText("salida_compilacion.txt").Contains("0 Errores"))
				{
					compilado = true;
				}
			} catch { }

			return compilado;
		}

		public static bool LimpiarCompilacion()
		{
			bool limpiado = true;
			try { Directory.Delete("PseudoPlayer", true); }
			catch 
			{ 
				Error = "Error al eliminar el proyecto compilado."; 
				limpiado = false;
			}

			try  { File.Delete("PseudoPlayer.zip"); } 
			catch 
			{ 
				Error = "Error al eliminar el archivo comprimido del proyecto."; 
				limpiado = false;
			}
			return limpiado;
		}
	}
}
