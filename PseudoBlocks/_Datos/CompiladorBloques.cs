using PseudoBlocks.Controlador;
using PseudoBlocks.Vista.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks._Datos
{
	class CompiladorBloques
	{
		static int contadorIds = 0;

		public static bool CompilarBloques(List<DatosBloque> bloques)
		{
			string rutaControlador = @".\PseudoPlayer\_Controlador\ControlJuego.cs";

			if (!File.Exists(rutaControlador)) return false;

			List<string> codigo = new List<string>();

			try
			{
				codigo = File.ReadAllLines(rutaControlador).ToList();
			}
			catch { return false; }

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
			catch { return false; }

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
	}
}
