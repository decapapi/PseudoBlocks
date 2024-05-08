using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PseudoBlocks.Vista.Controles;
using PseudoBlocks.Vista.Controles.Archivos;
using PseudoBlocks.Vista.Controles.Eventos;
using PseudoBlocks.Vista.Controles.Logica;
using PseudoBlocks.Vista.Controles.Numerico;
using PseudoBlocks.Controlador;
using System.IO.Compression;
using System.Diagnostics;
using PseudoBlocks._Datos;

namespace PseudoBlocks.Datos
{
	class ProjectManager
	{
		public static string ProyectoActual { get; private set; } = string.Empty;
		public static string NombreProyecto 
		{
			get
			{
				if (ProyectoActual.Equals(string.Empty))
				{
					return "Nuevo Proyecto";
				}
				else
				{
					return ProyectoActual.Substring(ProyectoActual.LastIndexOf('\\') + 1);
				}
			}
		}

		public static bool GuardarProyecto(List<DatosBloque> datos, bool actual = false)
		{
			if (actual && !actual.Equals(string.Empty))
			{
				return GuardarProyecto(datos, ProyectoActual);
			}
			else
			{
				FileDialog fileDialog = new SaveFileDialog();
				fileDialog.Filter = "PseudoBlocks Project|*.pbp";
				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					ProyectoActual = fileDialog.FileName;
					return GuardarProyecto(datos, fileDialog.FileName);
				}
			}
			return false;
		}

		private static bool GuardarProyecto(List<DatosBloque> datos, string archivo)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(archivo, false))
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DatosBloque>),
						new Type[] { typeof(DatosBloquePanel), typeof(DatosBloqueAudio),
							typeof(DatosBloqueImagen), typeof(DatosBloqueHotkey), typeof(DatosBloqueRepetir),
							typeof(DatosBloqueNumerico), typeof(DatosBloqueXY)});
					xmlSerializer.Serialize(sw, datos);
				}
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}

		public static List<Control> CargarProyecto()
		{
			List<Control> controles = new List<Control>();

			FileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "PseudoBlocks Project|*.pbp";
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				ProyectoActual = fileDialog.FileName;
				try
				{
					using (StreamReader sr = new StreamReader(fileDialog.FileName))
					{
						XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DatosBloque>),
								new Type[] { typeof(DatosBloquePanel), typeof(DatosBloqueAudio),
						typeof(DatosBloqueImagen), typeof(DatosBloqueHotkey), typeof(DatosBloqueRepetir),
						typeof(DatosBloqueNumerico), typeof(DatosBloqueXY)});

						List<DatosBloque> elementos = (List<DatosBloque>)xmlSerializer.Deserialize(sr);
						foreach (DatosBloque elemento in elementos)
						{
							Bloque bloque = CrearBloque(elemento);
							if (bloque != null)
							{
								controles.Add(bloque);
							}
						}
						return controles;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			return controles;
		}

		private static Bloque CrearBloque(DatosBloque elemento)
		{
			Bloque bloque = null;
			switch (elemento.Tipo)
			{
				case "move_right":
				case "move_left":
				case "move_up":
				case "move_down":
				case "logic_stopRepeating":
					bloque = new Bloque(elemento.Tipo, elemento.Texto, Color.FromArgb(elemento.Color));
					break;
				case "change_background":
				case "change_character":
					bloque = new BloqueImagen(elemento.Tipo, elemento.Texto, Color.FromArgb(elemento.Color), ((DatosBloqueImagen)elemento).Imagen);
					break;
				case "move_to":
				case "change_size":
					bloque = new BloqueXY(elemento.Tipo, elemento.Texto, Color.FromArgb(elemento.Color), ((DatosBloqueXY)elemento).X, ((DatosBloqueXY)elemento).Y);
					break;
				case "sound_play":
					bloque = new BloqueAudio(elemento.Tipo, elemento.Texto, Color.FromArgb(elemento.Color), ((DatosBloqueAudio)elemento).Audio);
					break;
				case "logic_wait":
					bloque = new BloqueNumerico(elemento.Tipo, elemento.Texto, Color.FromArgb(elemento.Color), ((DatosBloqueNumerico)elemento).Valor);
					break;
				case "logic_repeat":
					bloque = new BloqueRepetir(elemento.Tipo, elemento.Texto, Color.FromArgb(elemento.Color), ((DatosBloqueRepetir)elemento).Repeticiones);
					foreach (DatosBloque subElemento in ((DatosBloqueRepetir)elemento).Bloques)
					{
						Bloque subBloque = CrearBloque(subElemento);
						if (subBloque != null)
						{
							((BloqueRepetir)bloque).AgregarBloque(subBloque);
						}
					}
					break;
				case "logic_repeatAlways":
				case "event_onload":
					bloque = new BloquePanel(elemento.Tipo, elemento.Texto, Color.FromArgb(elemento.Color));
					foreach (DatosBloque subElemento in ((DatosBloquePanel)elemento).Bloques)
					{
						Bloque subBloque = CrearBloque(subElemento);
						if (subBloque != null)
						{
							((BloquePanel)bloque).AgregarBloque(subBloque);
						}
					}
					break;
				case "event_onpress":
					bloque = new BloqueHotkey(elemento.Tipo, elemento.Texto, Color.FromArgb(elemento.Color), ((DatosBloqueHotkey)elemento).Tecla);
					foreach (DatosBloque subElemento in ((DatosBloqueHotkey)elemento).Bloques)
					{
						Bloque subBloque = CrearBloque(subElemento);
						if (subBloque != null)
						{
							((BloqueHotkey)bloque).AgregarBloque(subBloque);
						}
					}
					break;
			}
			if (bloque != null)
				bloque.Location = elemento.Localizacion;
			return bloque;
		}

		public static bool ExportarProyecto(List<DatosBloque> datos)
		{
			Process.GetProcessesByName("PseudoPlayer").ToList().ForEach(p => p.Kill());

			if (!ExtraerProyecto()) return false;

			string rutaProyecto = @".\PseudoPlayer\PseudoPlayer.csproj";

			if (!File.Exists(rutaProyecto)) return false;

			if (!CompiladorBloques.CompilarBloques(datos)) return false;

			try
			{
				var proc = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = @"C:\Windows\System32\cmd.exe",
						Arguments = $"/c dotnet build {rutaProyecto} --configuration Release --property WarningLevel=1 > salida_compilacion.txt",
						UseShellExecute = false,
						CreateNoWindow = true,
						WorkingDirectory = Application.StartupPath,
						RedirectStandardOutput = true,
					}
				};

				proc.Start();
				proc.WaitForExit();
			} 
			catch 
			{ 
				return false; 
			}

			if (File.Exists("salida_compilacion.txt"))
			{
				if (!File.ReadAllText("salida_compilacion.txt").Contains("0 Errores")) return false;
			}

			LimpiarCompilacion();

			return true;
		}

		public static bool ExtraerProyecto()
		{
			byte[] zipFileBytes = Properties.Resources.PseudoPlayer_zip;
			
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

		public static void LimpiarCompilacion()
		{
			try { Directory.Delete("PseudoPlayer", true); } catch { }

			try { File.Delete("PseudoPlayer.zip"); } catch { }
		}
	}
}
