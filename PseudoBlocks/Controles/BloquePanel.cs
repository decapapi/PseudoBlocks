using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoBlocks.Controles
{
	public partial class BloquePanel : Bloque
	{
		private ListaItems listaItems = new ListaItems(false);

		public BloquePanel()
		{
			InitializeComponent();
		}

		public BloquePanel(string nombre) : base(nombre)
		{
			InitializeComponent();
		}

		public void AgregarBloque(Control control)
		{
			if (control is Bloque bloque)
			{
				bloque.AllowDragDrop = false;
				pnl_layout.Controls.Add(bloque);
				listaItems.Agregar(bloque);
				bloque.MouseUp += listaItems.OrdenarControles;
				bloque.ContextMenuStrip.ItemClicked += (sender, e) => EliminarComponente(bloque);
			}
		}

		public void EliminarComponente(Control componente)
		{
			pnl_layout.Controls.Remove(componente);
			listaItems.Eliminar(componente);
		}

		private void pnl_layout_DragEnter(object sender, DragEventArgs e)
		{
			if ((e.Data.GetData(typeof(Bloque)) is Bloque bloque
					&& !listaItems.Contiene(bloque) && !pnl_layout.Contains(bloque))
				|| (e.Data.GetData(typeof(BloquePanel)) is BloquePanel bloquePanel
					&& !listaItems.Contiene(bloquePanel) && !pnl_layout.Contains(bloquePanel)))
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void pnl_layout_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(typeof(Bloque)) is Bloque bloque)
			{
				Point clientPoint = pnl_layout.PointToClient(new Point(e.X, e.Y));
				bloque.Location = clientPoint;
				AgregarBloque(bloque);
			}
			if (e.Data.GetData(typeof(BloquePanel)) is BloquePanel bloquePanel)
			{
				Point clientPoint = pnl_layout.PointToClient(new Point(e.X, e.Y));
				bloquePanel.Location = clientPoint;
				AgregarBloque(bloquePanel);
			}
		}

		private void pnl_layout_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void OrdenarControles()
		{
			listaItems.OrdenarControles();
		}
	}
}
