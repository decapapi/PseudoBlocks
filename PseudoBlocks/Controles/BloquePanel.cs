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

		public BloquePanel(string tipo, string texto, Color color) : base(tipo, texto, color)
		{
			InitializeComponent();
			this.BackColor = color;
		}

		public void AgregarBloque(Control control)
		{
			if (control is Bloque bloque)
			{
				bloque.AllowDragDrop = false;
				bloque.MouseUp += (sender, e) => listaItems.OrdenarControles();
				bloque.ContextMenuStrip.ItemClicked += (sender, e) => EliminarComponente(bloque);
				pnl_layout.Controls.Add(bloque);
				listaItems.Agregar(bloque);
			}
		}

		public void EliminarComponente(Bloque bloque)
		{
			pnl_layout.Controls.Remove(bloque);
			listaItems.Eliminar(bloque);
			Actualizar();
		}

		private void pnl_layout_DragEnter(object sender, DragEventArgs e)
		{
			if ((e.Data.GetData(typeof(Bloque)) is Bloque)
				|| (e.Data.GetData(typeof(BloquePanel)) is BloquePanel))
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
				if (bloque != this)
				{
					Point clientPoint = pnl_layout.PointToClient(new Point(e.X, e.Y));
					bloque.Location = clientPoint;
					AgregarBloque(bloque);
				}
			}
			if (e.Data.GetData(typeof(BloquePanel)) is BloquePanel bloquePanel)
			{
				if (bloquePanel != this)
				{
					Point clientPoint = pnl_layout.PointToClient(new Point(e.X, e.Y));
					bloquePanel.Location = clientPoint;
					AgregarBloque(bloquePanel);
				}
			}
		}

		private void pnl_layout_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void Actualizar()
		{
			listaItems.OrdenarControles();
			if (Parent is Panel panel)
			{
				if (panel.Parent is BloquePanel bloquePanel)
				{
					bloquePanel.Actualizar();
				}
			}
		}
	}
}
