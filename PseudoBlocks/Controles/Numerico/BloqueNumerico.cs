using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks.Controles
{
	class BloqueNumerico : Bloque
	{
		private Numerico numerico;

		public BloqueNumerico(string tipo, string nombre, Color colorFondo,
			MouseEventHandler ordenarBotones, bool decimales = false)
			: base(tipo, nombre, colorFondo, ordenarBotones) 
		{
			this.numerico = new Numerico(decimales);
			base.AgregarControl(this.numerico);
		}

		public float GetNum()
		{
			return (float)this.numerico.Value;
		}
	}
}
