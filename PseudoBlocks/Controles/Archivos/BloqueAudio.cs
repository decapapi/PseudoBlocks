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
	public partial class BloqueAudio : Bloque
	{
		public string Audio { get; private set; }

		public BloqueAudio()
		{
			InitializeComponent();
		}

		public BloqueAudio(string tipo, string texto, Color color) : base(tipo, texto, color)
		{
			InitializeComponent();
		}

		private void SeleccionarArchivo(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "Archivos de audio|*.mp3;*.wav;*.ogg;";
			fd.Title = "Seleccionar archivo de audio";
			if (fd.ShowDialog() == DialogResult.OK)
			{
				this.Audio = fd.FileName;
				btn_seleccionar.Text = fd.SafeFileName;
			}
		}
	}
}
