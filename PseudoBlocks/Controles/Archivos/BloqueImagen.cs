using PseudoBlocks.Controles.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks.Controles
{
	class BloqueImagen : Bloque
	{
		private ImagePicker imagePicker;

		public BloqueImagen(string tipo, string nombre, Color colorFondo,
			MouseEventHandler ordenarBotones, bool decimales = false)
			: base(tipo, nombre, colorFondo, ordenarBotones) 
		{
			this.imagePicker = new ImagePicker();
			base.AgregarControl(this.imagePicker);
		}

		public string GetImagen()
		{
			return imagePicker.GetArchivo();
		}
	}
}
