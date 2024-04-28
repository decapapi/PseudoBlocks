using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoBlocks.Controles.Logica
{
	public partial class BloqueRepetir : BloquePanel
	{
		public BloqueRepetir()
		{
			InitializeComponent();
		}

		public BloqueRepetir(string tipo, string texto, Color color) : base(tipo, texto, color)
		{
			InitializeComponent();
		}

		public int GetNumero()
		{
			return (int)nud_num.Value;
		}
	}
}
