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

namespace PseudoBlocks
{
	public partial class frm_Editor : Form
	{
		private ListaItems listaItems = new ListaItems(new Point(10, 10));

		public frm_Editor()
		{
			InitializeComponent();
		}

		public void AgregarComponente(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				string controlName = control.Name;
				string controlType = controlName.Substring(controlName.IndexOf('_') + 1);
				if (controlType.StartsWith("move"))
				{
					AgregarControl(new Bloque(controlType, control.Text, Color.MediumAquamarine));
				}
				if (controlType.StartsWith("change"))
				{
					if (controlType.EndsWith("background"))
					{
						AgregarControl(new BloqueImagen(controlType, control.Text, Color.LightBlue));
					}
					if (controlType.EndsWith("character"))
					{
						AgregarControl(new BloqueImagen(controlType, control.Text, Color.LightBlue));
					}

					if (controlType.EndsWith("size"))
					{
						AgregarControl(new BloqueXY(controlType, control.Text, Color.LightBlue));
					}
				}
				if (controlType.StartsWith("sound"))
				{
					AgregarControl(new BloqueAudio(controlType, control.Text, Color.FromArgb(255, 192, 255)));
				}
				if (controlType.StartsWith("logic"))
				{
					if (controlType.EndsWith("wait"))
					{
						AgregarControl(new BloqueNumerico(controlType, control.Text, Color.LightSalmon));
					}
					if (controlType.EndsWith("repeat"))
					{
						AgregarControl(new BloqueRepetir(controlType, control.Text, Color.LightSalmon));
					}
					if (controlType.EndsWith("repeat_always"))
					{
						AgregarControl(new BloquePanel(controlType, control.Text, Color.LightSalmon));
					}
				}
				if (controlType.StartsWith("event"))
				{
					if (controlType.EndsWith("onload"))
					{
						AgregarControl(new BloquePanel(controlType, control.Text, Color.LightCoral));
					}
					if (controlType.EndsWith("onpress"))
					{
						AgregarControl(new BloqueHotkey(controlType, control.Text, Color.LightCoral));
					}
					if (controlType.EndsWith("onclick"))
					{
						AgregarControl(new BloquePanel(controlType, control.Text, Color.LightCoral));
					}
				}
			}
		}

		private void AgregarControl(Control control)
		{
			listaItems.Agregar(control);
			pnl_layout_principal.Controls.Add(control);
			control.ContextMenuStrip.ItemClicked += (sender, e) => EliminarComponente(control);
			control.BringToFront();
		}

		public void EliminarComponente(Control control)
		{
			pnl_layout_principal.Controls.Remove(control);
			listaItems.Eliminar(control);
		}

		// Cuando se presiona un botón de categoría, mostrar los controles de esa categoría
		private void CambiarCategoria(object sender, EventArgs e)
		{
			if (sender is Button btn)
			{
				switch (btn.Name.Substring(btn.Name.IndexOf('_') + 1))
				{
					case "movimiento":
						btn_movimiento.BackColor = Color.LightGray;
						pnl_components.ScrollControlIntoView(pnl_movimiento);
						break;
					case "escenario":
						btn_escenario.BackColor = Color.LightGray;
						pnl_components.ScrollControlIntoView(pnl_escenario);
						break;
					case "sonido":
						btn_sonido.BackColor = Color.LightGray;
						pnl_components.ScrollControlIntoView(pnl_sonido);
						break;
					case "logica":
						btn_logica.BackColor = Color.LightGray;
						pnl_components.ScrollControlIntoView(pnl_logica);
						break;
					case "eventos":
						btn_eventos.BackColor = Color.LightGray;
						pnl_components.ScrollControlIntoView(pnl_eventos);
						break;
				}
				pnl_components.Refresh();
			}
		}
	}
}
