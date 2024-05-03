using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoPlayer._Vista
{
	public partial class Personaje : UserControl
	{
		public Personaje(int x, int y)
		{
			InitializeComponent();
			this.Location = new Point(x - this.Width / 2, y - this.Height / 2);
		}

		public void CambiarPersonaje(Image imagen)
		{
			this.BackgroundImage = imagen;
		}

		public void MoverDerecha()
		{
			MoverA(this.Location.X + 5, this.Location.Y);
		}

		public void MoverIzquierda()
		{
			MoverA(this.Location.X - 5, this.Location.Y);
		}

		public void MoverArriba()
		{
			MoverA(this.Location.X, this.Location.Y - 5);
		}

		public void MoverAbajo()
		{
			MoverA(this.Location.X, this.Location.Y + 5);
		}

		public void MoverA(int x, int y)
		{
			x = Math.Max(0, Math.Min(x, this.Parent.Width - this.Width));
			y = Math.Max(0, Math.Min(y, this.Parent.Height - this.Height));
			this.Location = new Point(x , y );
		}
	}
}
