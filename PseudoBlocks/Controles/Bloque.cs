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
		public bool AllowDragDrop { get; set; } = true;
		private Point MouseDownLocation;

		public Bloque()
		{
			InitializeComponent();
			this.ContextMenuStrip = bloque_menu;
		}

		public Bloque(string texto)
		{
			InitializeComponent();
			controlName.Text = texto;
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
				this.DoDragDrop(this, DragDropEffects.Move);
			}
		}
	}
}
