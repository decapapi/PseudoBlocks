using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PseudoBlocks.Controles;
using PseudoBlocks.Controles.Archivos;
using PseudoBlocks.Controles.Eventos;
using PseudoBlocks.Controles.Logica;
using PseudoBlocks.Controles.Numerico;

namespace PseudoBlocks
{
	class ProjectManager
	{
		public static bool SaveProject(List<DatosBloque> datos)
		{
			FileDialog fileDialog = new SaveFileDialog();
			fileDialog.Filter = "PseudoBlocks Project|*.pbp";
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (StreamWriter sw = new StreamWriter(fileDialog.FileName, false))
					{
						XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DatosBloque>),
							new Type[] { typeof(DatosBloquePanel), typeof(DatosBloqueAudio),
							typeof(DatosBloqueImagen), typeof(DatosBloqueHotkey), typeof(DatosBloqueRepetir),
							typeof(DatosBloqueNumerico), typeof(DatosBloqueXY)});
						xmlSerializer.Serialize(sw, datos);
					}
				} catch (Exception ex)
				{
					MessageBox.Show("Error al guardar el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			return true;
		}

		public static List<Control> LoadProject()
		{
			List<Control> controles = new List<Control>();

			FileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "PseudoBlocks Project|*.pbp";
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (StreamReader sr = new StreamReader(fileDialog.FileName))
					{
						XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DatosBloque>),
								new Type[] { typeof(DatosBloquePanel), typeof(DatosBloqueAudio),
								typeof(DatosBloqueImagen), typeof(DatosBloqueHotkey), typeof(DatosBloqueRepetir),
								typeof(DatosBloqueNumerico), typeof(DatosBloqueXY)});

						List<DatosBloque> datos = (List<DatosBloque>)xmlSerializer.Deserialize(sr);
						foreach (DatosBloque dato in datos)
						{
							Bloque bloque;
							switch (dato.Tipo)
							{
								case "move_right":
								case "move_left":
								case "move_up":
								case "move_down":
									bloque = new Bloque(dato.Tipo, dato.Texto, Color.FromArgb(dato.Color));
									bloque.Location = dato.Localizacion;
									controles.Add(bloque);
									break;
								case "change_background":
								case "change_character":
									bloque = new BloqueImagen(dato.Tipo, dato.Texto, Color.FromArgb(dato.Color), ((DatosBloqueImagen)dato).Imagen);
									bloque.Location = dato.Localizacion;
									controles.Add(bloque);
									break;
							}
						}
						return controles;
					}
				} catch (Exception ex)
				{
					MessageBox.Show("Error al cargar el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			return controles;
		}
	}
}
