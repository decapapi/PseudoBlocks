using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
using PseudoBlocks.Controles;
using PseudoBlocks.Controles.Extensiones;

namespace PseudoBlocks
{
	public partial class PruebaGrafica : Form
	{
		private ListaItems listaItems = new ListaItems();

		public PruebaGrafica()
		{
			InitializeComponent();
		}

		public void AgregarComponente(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				BloquePanel bloque = new BloquePanel();
				bloque.ContextMenuStrip = bloque_menu;
				listaItems.Agregar(bloque);
				AgregarControl(pnl_layout, bloque);
			}
		}

		private void EliminarComponente(object sender, EventArgs e)
		{
			if (sender is ToolStripMenuItem menuItem)
			{
				if (menuItem.Owner is ContextMenuStrip contextMenu)
				{
					if (contextMenu.SourceControl is Control control)
					{
						pnl_layout.Controls.Remove(control);
						listaItems.Eliminar(control);
					}
				}
			}
		}

		private void AgregarControl(Panel panel, Control control)
		{
			panel.Controls.Add(control);
			control.Draggable(true);
			control.BringToFront();
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
