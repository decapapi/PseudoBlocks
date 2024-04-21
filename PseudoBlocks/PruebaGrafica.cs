using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using PseudoBlocks.Controles;
using PseudoBlocks.Controles.Extensiones;

namespace PseudoBlocks
{
	public partial class PruebaGrafica_ : Form
	{
		private ListaItems listaItems = new ListaItems();

		public PruebaGrafica_()
		{
			InitializeComponent();
		}

		public void AgregarComponente(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				string controlName = control.Name;
				int controlType = 0;
				bool decimales = false;
				Color color = Color.Empty;

				switch (controlName.Substring(0, controlName.LastIndexOf('_')))
				{
					case "btn_move":
						color = Color.MediumAquamarine;
						break;
					case "btn_logic":
						if (controlName.EndsWith("_w") || controlName.EndsWith("_rs"))
							controlType = 1;
						if (controlName.EndsWith("_w"))
							decimales = true;
						color = Color.LightSalmon;
						break;
					case "btn_change":
						color = Color.LightBlue;
						controlType = 2;
						break;
					case "btn_sound":
						color = Color.MediumPurple;
						controlType = 3;
						break;
					default:
						MessageBox.Show("Control no reconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						controlType = -1;
						break;
				}

				if (!color.IsEmpty)
				{
					Bloque? nuevoBloque = null;
					switch (controlType)
					{
						case 0:
							nuevoBloque = new Bloque(control.Name, control.Text, color, listaItems.OrdenarControles, ActualizarPanel);
							break;
						case 1:
							nuevoBloque = new BloqueNumerico(control.Name, control.Text, color, listaItems.OrdenarControles, ActualizarPanel, decimales);
							break;
						case 2:
							nuevoBloque = new BloqueImagen(control.Name, control.Text, color, listaItems.OrdenarControles, ActualizarPanel);
							break;
						case 3:
							nuevoBloque = new BloqueAudio(control.Name, control.Text, color, listaItems.OrdenarControles, ActualizarPanel);
							break;
					}

					if (nuevoBloque != null)
					{
						nuevoBloque.ContextMenuStrip = bloque_menu;
						nuevoBloque.SetPosicion(listaItems.UltimaPosicion());
						listaItems.Agregar(nuevoBloque);
						listaItems.OrdenarControles();
						AgregarControl(pnl_layout, nuevoBloque);
						ActualizarPanel();
					}
				}
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
						listaItems.Items.Remove(control);
						ActualizarPanel();
					}
				}
			}
		}

		private void ActualizarPanel()
		{
			ActualizarPanel(null!, null!);
		}

		private void ActualizarPanel(object? sender, EventArgs? e)
		{
			if (listaItems.Items.Count > 0)
			{
				Point localizacion = listaItems.PrimeraPosicion();
				if (localizacion.Y < 10)
					localizacion.Y = 10;
				if (localizacion.X < 10)
					localizacion.X = 10;
				
				foreach (Control item in listaItems.Items)
				{
					item.Location = localizacion;
					localizacion.Y += 40;
				}
			}
		}

		private void AgregarControl(Panel panel, Control control)
		{
			panel.Controls.Add(control);
			control.Draggable(true);
			control.BringToFront();
		}
	}
}
