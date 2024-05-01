using Microsoft.VisualBasic.Devices;
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

		public BloqueImagen(string tipo, string texto, Color color, string imagen) : base(tipo, texto, color)
		{
			InitializeComponent();
			this.Imagen = imagen;
			btn_seleccionar.Text = imagen.Substring(imagen.LastIndexOf('\\') + 1);
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

		public override DatosBloqueImagen GetDatos()
		{
			return new DatosBloqueImagen(Tipo, controlName.Text, BackColor.ToArgb(), Location, Imagen);
		}
	}
}
