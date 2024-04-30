using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks
{
	public class DatosBloque
	{
		public string Tipo { get; private set; }
		public string Texto { get; private set; }
		public Color Color { get; private set; }

		public DatosBloque(string tipo, string texto, Color color)
		{
			this.Tipo = tipo;
			this.Texto = texto;
			this.Color = color;
		}
	}

	public class DatosBloquePanel : DatosBloque
	{
		public List<DatosBloque> Bloques { get; private set; }

		public DatosBloqueAudio(string tipo, string texto, Color color, List<DatosBloque> bloques) : base(tipo, texto, color)
		{
			this.Bloques = bloques;
		}
	}

	public class DatosBloqueAudio : DatosBloque
	{
		public string Audio { get; private set; }

		public DatosBloqueAudio(string tipo, string texto, Color color, string audio) : base(tipo, texto, color)
		{
			this.Audio = audio;
		}
	}

	public class DatosBloqueImagen : DatosBloque
	{
		public string Imagen { get; private set; }

		public DatosBloqueImagen(string tipo, string texto, Color color, string imagen) : base(tipo, texto, color)
		{
			this.Imagen = imagen;
		}
	}

	public class DatosBloqueHotkey : DatosBloque
	{
		public Keys Tecla { get; private set; }

		public DatosBloqueHotkey(string tipo, string texto, Color color, Keys tecla) : base(tipo, texto, color)
		{
			this.Tecla = tecla;
		}
	}

	public class DatosBloqueRepetir : DatosBloquePanel
	{
		public int Repeticiones { get; private set; }

		public DatosBloqueRepetir(string tipo, string texto, Color color, List<DatosBloque> bloques, int repeticiones) : base(tipo, texto, color, bloques)
		{
			this.Repeticiones = repeticiones;
		}
	}

	public class DatosBloqueNumerico : DatosBloque
	{
		public int Valor { get; private set; }

		public DatosBloqueNumerico(string tipo, string texto, Color color, int valor) : base(tipo, texto, color)
		{
			this.Valor = valor;
		}
	}

	public class DatosBloqueXY : DatosBloque
	{
		public int X { get; private set; }
		public int Y { get; private set; }

		public DatosBloqueXY(string tipo, string texto, Color color, int x, int y) : base(tipo, texto, color)
		{
			this.X = x;
			this.Y = y;
		}
	}
}
