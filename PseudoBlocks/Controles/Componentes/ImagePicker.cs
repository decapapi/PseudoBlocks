using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks.Controles.Archivos
{
	class ImagePicker : FilePicker
	{
		public ImagePicker()
		{
			this.Click += new EventHandler(SeleccionarImagen);
		}

		private void SeleccionarImagen(object? sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;";
			fd.Title = "Seleccionar imagen";
			if (fd.ShowDialog() == DialogResult.OK)
			{
				base.archivo = fd.FileName;
				this.Text = fd.SafeFileName;
			}
		}
	}
}
