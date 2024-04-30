using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoBlocks.Controles.Numerico
{
	public partial class BloqueXY : Bloque
	{
		public BloqueXY()
		{
			InitializeComponent();
		}

		public BloqueXY(string tipo, string texto, Color color) : base(tipo, texto, color)
		{
			InitializeComponent();
		}

		public int GetX()
		{
			return (int)nud_X.Value;
		}

		public int GetY()
		{
			return (int)nud_Y.Value;
		}

		public Point GetLocation()
		{
			return new Point(GetX(), GetY());
		}

		public override DatosBloqueXY GetDatos()
		{
			return new DatosBloqueXY(Tipo, controlName.Text, BackColor.ToArgb(), GetLocation(), GetX(), GetY());
		}
	}
}
