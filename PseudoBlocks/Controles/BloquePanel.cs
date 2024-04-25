using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PseudoBlocks.Controles.Extensiones;

namespace PseudoBlocks.Controles
{
	public partial class BloquePanel : UserControl
	{
		private ListaItems listaItems = new ListaItems(false);

		public BloquePanel()
		{
			InitializeComponent();
			for (int i = 0; i <= 4; i++)
				AgregarComponente(new Bloque($"Bloque #{i}"));
		}

		public void AgregarComponente(Control control)
		{
			control.ContextMenuStrip = bloque_menu;
			control.MouseUp += listaItems.OrdenarControles;
			pnl_layout.Controls.Add(control);
			listaItems.Agregar(control);
		}

		public void EliminarComponente(Control componente)
		{
			pnl_layout.Controls.Remove(componente);
			listaItems.Eliminar(componente);
		}
	}
}
