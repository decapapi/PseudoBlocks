using PseudoBlocks.Controles.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks.Controles
{
	class BloqueAudio : Bloque
	{
		private AudioPicker audioPicker;

		public BloqueAudio(string tipo, string nombre, Color colorFondo,
			MouseEventHandler ordenarBotones, bool decimales = false)
			: base(tipo, nombre, colorFondo, ordenarBotones) 
		{
			this.audioPicker = new AudioPicker();
			base.AgregarControl(this.audioPicker);
		}

		public string GetImagen()
		{
			return audioPicker.GetArchivo();
		}
	}
}
