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
	public partial class BloqueNumerico : Bloque
	{
		public BloqueNumerico()
		{
			InitializeComponent();
		}

		public BloqueNumerico(string tipo, string texto, Color color) : base(tipo, texto, color)
		{
			InitializeComponent();
		}

		public int GetValue()
		{
			return (int)nud_num.Value;
		}
	}
}
