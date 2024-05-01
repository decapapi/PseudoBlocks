using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PseudoBlocks.Controlador;

namespace PseudoBlocks.Vista.Controles.Logica
{
	public partial class BloqueRepetir : BloquePanel
	{
		public BloqueRepetir()
		{
			InitializeComponent();
		}

		public BloqueRepetir(string tipo, string texto, Color color) : base(tipo, texto, color)
		{
			InitializeComponent();
		}

		public BloqueRepetir(string tipo, string texto, Color color, int repeticiones) : base(tipo, texto, color)
		{
			InitializeComponent();
			nud_num.Value = repeticiones;
		}

		public int GetNumero()
		{
			return (int)nud_num.Value;
		}

		public override DatosBloqueRepetir GetDatos()
		{
			List<DatosBloque> bloques = new List<DatosBloque>();
			foreach (Bloque bloque in listaItems.Bloques)
			{
				bloques.Add(bloque.GetDatos());
			}
			return new DatosBloqueRepetir(Tipo, controlName.Text, BackColor.ToArgb(), Location, bloques, GetNumero());
		}
	}
}
