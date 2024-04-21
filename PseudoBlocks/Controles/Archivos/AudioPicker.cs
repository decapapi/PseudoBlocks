using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks.Controles.Archivos
{
	class AudioPicker : FilePicker
	{
		public AudioPicker()
		{
			this.Click += new EventHandler(SeleccionarAudio);
		}

		private void SeleccionarAudio(object? sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "Archivos de audio|*.mp3;*.wav;*.ogg;";
			fd.Title = "Seleccionar archivo de audio";
			if (fd.ShowDialog() == DialogResult.OK)
			{
				base.archivo = fd.FileName;
				this.Text = fd.SafeFileName;
			}
		}
	}
}
