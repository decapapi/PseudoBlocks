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
		public string? Tecla { get; private set; } = null;
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
				esperandoTecla = false;
			}
		}

		private void EstablecerTecla(object sender, EventArgs e)
		{
			Tecla = null;
			esperandoTecla = true;
			btn_seleccionar.Text = "Esperando tecla...";
			while (esperandoTecla)
			{
				Application.DoEvents();
			}
			esperandoTecla = false;
		}

		private void CancelarCapturar(object sender, EventArgs e)
		{
			if (esperandoTecla && Tecla == null)
			{
				esperandoTecla = false;
				btn_seleccionar.Text = "Seleccionar...";
			}
		}
	}
}
