using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PseudoBlocks.Controles.Extensiones;

namespace PseudoBlocks.Controles
{
	public partial class BloquePanel : UserControl
	{
		private ListaItems listaItems = new ListaItems(false);

		public BloquePanel()
		{
			InitializeComponent();
		}

		public void AgregarComponente(Control control)
		{
			control.ContextMenuStrip = bloque_menu;
			control.MouseUp += listaItems.OrdenarControles;
			listaItems.Agregar(control);
			pnl_layout.Controls.Add(control);
		}

		public void EliminarComponente(Control componente)
		{
			pnl_layout.Controls.Remove(componente);
			listaItems.Eliminar(componente);
		}

		private void pnl_layout_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(typeof(Bloque)) is Bloque bloque
					&& !listaItems.Contiene(bloque) && !pnl_layout.Contains(bloque))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void pnl_layout_DragDrop(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void pnl_layout_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(typeof(Bloque)) is Bloque bloque
									&& !listaItems.Contiene(bloque))
			{
				Point clientPoint = pnl_layout.PointToClient(new Point(e.X, e.Y));
				bloque.Location = clientPoint;
				AgregarComponente(bloque);
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
	}
}
