using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoBlocks.Controles.Eventos
{
	public partial class BloqueHotkey : BloquePanel
	{
		public Keys Tecla { get; private set; } = Keys.None;
		private bool esperandoTecla = false;

		public BloqueHotkey()
		{
			InitializeComponent();
		}

		public BloqueHotkey(string tipo, string texto, Color color) : base(tipo, texto, color)
		{
			InitializeComponent();
		}

		public BloqueHotkey(string tipo, string texto, Color color, Keys tecla) : base(tipo, texto, color)
		{
			InitializeComponent();
			Tecla = tecla;
		}

		private void CapturarTecla(object sender, KeyEventArgs e)
		{
			if (esperandoTecla)
			{
				Tecla = e.KeyCode;
				btn_seleccionar.Text = Tecla.ToString();
				esperandoTecla = false;
			}
		}

		private void EstablecerTecla(object sender, EventArgs e)
		{
			Tecla = Keys.None;
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
			if (esperandoTecla && Tecla == Keys.None)
			{
				esperandoTecla = false;
				btn_seleccionar.Text = "Seleccionar...";
			}
		}

		public override DatosBloqueHotkey GetDatos()
		{
			List<DatosBloque> bloques = new List<DatosBloque>();
			foreach (Bloque bloque in listaItems.Bloques)
			{
				bloques.Add(bloque.GetDatos());
			}
			return new DatosBloqueHotkey(Tipo, controlName.Text, BackColor.ToArgb(), Location, Tecla, bloques);
		}
	}
}
