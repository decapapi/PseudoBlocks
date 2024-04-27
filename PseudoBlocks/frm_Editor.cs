using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
using PseudoBlocks.Controles;

namespace PseudoBlocks
{
	public partial class frm_Editor : Form
	{
		private ListaItems listaItems = new ListaItems(new Point(10, 10));

		public frm_Editor()
		{
			InitializeComponent();
			AgregarControl(new BloquePanel());
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
