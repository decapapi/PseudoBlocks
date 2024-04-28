using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoBlocks.Controles.Eventos
{
	public partial class BloqueHotkey : BloquePanel
	{
		public string Tecla { get; private set; } = null;
		private bool esperandoTecla = false;

		public BloqueHotkey()
		{
			InitializeComponent();
		}

		public BloqueHotkey(string tipo, string texto, Color color) : base(tipo, texto, color)
		{
			InitializeComponent();
		}

		private void CapturarTecla(object sender, KeyEventArgs e)
		{
			if (esperandoTecla)
			{
				Tecla = e.KeyCode.ToString();
				btn_seleccionar.Text = Tecla;
			}
		}

		private void EstablecerTecla(object sender, EventArgs e)
		{
			esperandoTecla = true;
			Tecla = null;
			while (Tecla == null)
			{
				Application.DoEvents();
			}
			esperandoTecla = false;
		}
	}
}
