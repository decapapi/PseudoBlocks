using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
using PseudoBlocks.Controles;
using PseudoBlocks.Controles.Archivos;
using PseudoBlocks.Controles.Numerico;
using PseudoBlocks.Controles.Logica;
using PseudoBlocks.Controles.Eventos;
using System.Text.Json;

namespace PseudoBlocks
{
	public partial class frm_Editor : Form
	{
		public frm_Editor()
		{
			InitializeComponent();
		}

		public void AgregarComponente(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				string controlType = control.Name.Substring(control.Name.IndexOf('_') + 1);
				string[] controlInfo = controlType.Split('_');
				switch (controlInfo[0])
				{
					case "move": // Movimiento
						AgregarControl(new Bloque(controlType, control.Text, Color.MediumAquamarine));
						break;
					case "change": // Escenario
						switch (controlInfo[1])
						{
							case "background":
							case "character":
								AgregarControl(new BloqueImagen(controlType, control.Text, Color.LightBlue));
								break;
							case "size":
								AgregarControl(new BloqueXY(controlType, control.Text, Color.LightBlue));
								break;
						}
						break;
					case "sound": // Sonido
						AgregarControl(new BloqueAudio(controlType, control.Text, Color.FromArgb(255, 192, 255)));
						break;
					case "logic": // Lógica
						switch (controlInfo[1])
						{
							case "wait":
								AgregarControl(new BloqueNumerico(controlType, control.Text, Color.LightSalmon));
								break;
							case "repeat":
								AgregarControl(new BloqueRepetir(controlType, control.Text, Color.LightSalmon));
								break;
							case "repeatAlways":
								AgregarControl(new BloquePanel(controlType, control.Text, Color.LightSalmon));
								break;
						}
						break;
					case "event": // Eventos
						switch (controlInfo[1])
						{
							case "onload":
							case "onclick":
								AgregarControl(new BloquePanel(controlType, control.Text, Color.LightCoral));
								break;
							case "onpress":
								AgregarControl(new BloqueHotkey(controlType, control.Text, Color.LightCoral));
								break;
						}
						break;
				}
			}
		}

		private void AgregarControl(Bloque control, bool randomPos = true)
		{
			pnl_layout_principal.Controls.Add(control);
			Random rdm = new Random();
			if (randomPos)
			{
				control.Location = new Point(rdm.Next(10, 
					pnl_layout_principal.Width - control.Width), rdm.Next(rdm.Next(10, 20)));
			}
			control.ContextMenuStrip.ItemClicked += (sender, e) => EliminarControl(control);
			control.BringToFront();
		}

		private void EliminarControl(Bloque control)
		{
			pnl_layout_principal.Controls.Remove(control);
		}

		private void CambiarCategoria(object sender, EventArgs e)
		{
			if (sender is Button btn)
			{
				switch (btn.Name.Substring(btn.Name.IndexOf('_') + 1))
				{
					case "movimiento":
						pnl_components.ScrollControlIntoView(pnl_movimiento);
						break;
					case "escenario":
						pnl_components.ScrollControlIntoView(pnl_escenario);
						break;
					case "sonido":
						pnl_components.ScrollControlIntoView(pnl_sonido);
						break;
					case "logica":
						pnl_components.ScrollControlIntoView(pnl_logica);
						break;
					case "eventos":
						pnl_components.ScrollControlIntoView(pnl_eventos);
						break;
				}
			}
		}

		private void Cerrar(object sender, EventArgs e)
		{
			this.Close();
		}


		private void AbrirProyecto(object sender, EventArgs e)
		{
			List<Control> controles = ProjectManager.LoadProject();
			if (controles.Count > 0)
			{
				pnl_layout_principal.Controls.Clear();
				foreach (Bloque control in controles)
				{
					AgregarControl(control, false);
				}
			}
        }

		private void GuardarProyecto(object sender, EventArgs e)
		{
			List<DatosBloque> datos = new List<DatosBloque>();
			foreach (Bloque control in pnl_layout_principal.Controls)
			{
				datos.Add(control.GetDatos());
			}
			ProjectManager.SaveProject(datos);
		}
	}
}
