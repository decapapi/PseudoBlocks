using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks
{
	public class DatosBloque
	{
		public string Tipo { get; set; }
		public string Texto { get; set; }
		public int Color { get; set; }
		public Point Localizacion { get; set; }

		private DatosBloque() { }

		public DatosBloque(string tipo, string texto, int color, Point localizacion)
		{
			this.Tipo = tipo;
			this.Texto = texto;
			this.Color = color;
			this.Localizacion = localizacion;
		}
	}

	public class DatosBloquePanel : DatosBloque
	{
		public List<DatosBloque> Bloques { get; set; }

		private DatosBloquePanel() : base(String.Empty, String.Empty, 0, new Point(0 ,0)) { }

		public DatosBloquePanel(string tipo, string texto, int color, Point localizacion, List<DatosBloque> bloques) 
			: base(tipo, texto, color, localizacion)
		{
			this.Bloques = bloques;
		}
	}

	public class DatosBloqueAudio : DatosBloque
	{
		public string Audio { get; set; }

		private DatosBloqueAudio() : base(String.Empty, String.Empty, 0, new Point(0, 0)) { }

		public DatosBloqueAudio(string tipo, string texto, int color, Point localizacion, string audio) 
			: base(tipo, texto, color, localizacion)
		{
			this.Audio = audio;
		}
	}

	public class DatosBloqueImagen : DatosBloque
	{
		public string Imagen { get; set; }

		private DatosBloqueImagen() : base(String.Empty, String.Empty, 0, new Point(0, 0)) { }

		public DatosBloqueImagen(string tipo, string texto, int color, Point localizacion, string imagen) 
			: base(tipo, texto, color, localizacion)
		{
			this.Imagen = imagen;
		}
	}

	public class DatosBloqueHotkey : DatosBloquePanel
	{
		public Keys Tecla { get; set; }

		private DatosBloqueHotkey() : base(String.Empty, String.Empty, 0, new Point(0, 0), new List<DatosBloque>()) { }

		public DatosBloqueHotkey(string tipo, string texto, int color, Point localizacion, Keys tecla, List<DatosBloque> bloques) 
			: base(tipo, texto, color, localizacion, bloques)
		{
			this.Tecla = tecla;
		}
	}

	public class DatosBloqueRepetir : DatosBloquePanel
	{
		public int Repeticiones { get; set; }

		private DatosBloqueRepetir() : base(String.Empty, String.Empty, 0, new Point(0, 0), new List<DatosBloque>()) { }

		public DatosBloqueRepetir(string tipo, string texto, int color, Point localizacion, List<DatosBloque> bloques, int repeticiones) 
			: base(tipo, texto, color, localizacion, bloques)
		{
			this.Repeticiones = repeticiones;
		}
	}

	public class DatosBloqueNumerico : DatosBloque
	{
		public int Valor { get; set; }

		private DatosBloqueNumerico() : base(String.Empty, String.Empty, 0, new Point(0, 0)) { }

		public DatosBloqueNumerico(string tipo, string texto, int color, Point localizacion, int valor) 
			: base(tipo, texto, color, localizacion)
		{
			this.Valor = valor;
		}
	}

	public class DatosBloqueXY : DatosBloque
	{
		public int X { get; set; }
		public int Y { get; set; }

		private DatosBloqueXY() : base(String.Empty, String.Empty, 0, new Point(0, 0)) { }

		public DatosBloqueXY(string tipo, string texto, int color, Point localizacion, int x, int y) 
			: base(tipo, texto, color, localizacion)
		{
			this.X = x;
			this.Y = y;
		}
	}
}
