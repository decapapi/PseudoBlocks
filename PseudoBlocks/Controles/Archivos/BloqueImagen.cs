using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoBlocks.Controles.Archivos
{
	public partial class BloqueImagen : Bloque
	{
		public string Imagen { get; private set; }

		public BloqueImagen()
		{
			InitializeComponent();
		}

		public BloqueImagen(string tipo, string texto, Color color) : base(tipo, texto, color)
		{
			InitializeComponent();
		}

		private void SeleccionarArchivo(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;";
			fd.Title = "Seleccionar imagen";
			if (fd.ShowDialog() == DialogResult.OK)
			{
				this.Imagen = fd.FileName;
				btn_seleccionar.Text = fd.SafeFileName;
			}
		}
	}
}
