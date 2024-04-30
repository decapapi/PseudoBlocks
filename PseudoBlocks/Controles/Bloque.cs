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
	public partial class Bloque : UserControl
	{
		public string Tipo { get; private set; }
		public bool AllowDragDrop { get; set; } = true;
		private Point MouseDownLocation;

		public Bloque()
		{
			InitializeComponent();
			this.ContextMenuStrip = bloque_menu;
		}

		public Bloque(string tipo, string texto, Color color)
		{
			InitializeComponent();
			this.Tipo = tipo;
			controlName.Text = texto;
			this.BackColor = color;
			this.ContextMenuStrip = bloque_menu;
		}

		private void Arrastrar(object sender, MouseEventArgs e) // MouseDown
		{
			if (e.Button == MouseButtons.Left)
			{
				MouseDownLocation = e.Location;
				this.BringToFront();
			}
		}

		private void Mover(object sender, MouseEventArgs e) // MouseMove
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left = e.X + this.Left - MouseDownLocation.X;
				this.Top = e.Y + this.Top - MouseDownLocation.Y;
			}
		}

		private void Soltar(object sender, MouseEventArgs e) // MouseUp
		{
			if (AllowDragDrop && e.Button == MouseButtons.Left)
			{
				this.DoDragDrop(new DataObject(DataFormats.Serializable, this), DragDropEffects.Move);
				if (this.Location.Y < 0)
				{
					this.Location = new Point(this.Location.X, 0);
				}
				if (this.Location.X < 0)
				{
					this.Location = new Point(0, this.Location.Y);
				}
			}
		}
		
		public virtual DatosBloque GetDatos()
		{
			return new DatosBloque(Tipo, controlName.Text, BackColor.ToArgb(), Location);
		}
	}
}
