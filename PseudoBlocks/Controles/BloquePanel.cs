using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PseudoBlocks.Controles.Logica;

namespace PseudoBlocks.Controles
{
	public partial class BloquePanel : Bloque
	{
		protected readonly ListaItems listaItems = new ListaItems(false);

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

		private void DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(DataFormats.Serializable) is Bloque)
			{
				e.Effect = DragDropEffects.Move;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(DataFormats.Serializable) is Bloque bloque)
			{
				if (bloque != this)
				{
					Point clientPoint = pnl_layout.PointToClient(new Point(e.X, e.Y));
					bloque.Location = clientPoint;
					AgregarBloque(bloque);
				}
			}
		}

		private void DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		public void Actualizar()
		{
			listaItems.OrdenarControles();
			if (Parent is Panel panel)
			{
				if (panel.Parent is BloquePanel bloquePanel)
				{
					bloquePanel.Actualizar();
				}
				if (panel.Parent is BloqueRepetir bloqueRepetir)
				{
					bloqueRepetir.Actualizar();
				}
			}
		}

		public override DatosBloquePanel GetDatos()
		{
			List<DatosBloque> bloques = new List<DatosBloque>();
			foreach (Bloque bloque in listaItems.Bloques)
			{
				bloques.Add(bloque.GetDatos());
			}
			return new DatosBloquePanel(Tipo, controlName.Text, BackColor.ToArgb(), Location, bloques);
		}
	}
}
