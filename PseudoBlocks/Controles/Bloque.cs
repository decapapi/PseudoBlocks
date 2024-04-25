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
	public partial class Bloque : UserControl
	{
		public Bloque()
		{
			InitializeComponent();
		}

		public Bloque(string texto)
		{
			InitializeComponent();
			controlName.Text = texto;
		}
	}
}
