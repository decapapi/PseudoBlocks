using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using PseudoBlocks.Controles.Extensiones;

namespace PseudoBlocks.Controles
{
	class Bloque : TableLayoutPanel
	{
		private static int _id = 0;

		public Bloque(string tipo, string nombre, Color colorFondo,
			MouseEventHandler ordenarBotones, MouseEventHandler actualizarPanel)
		{
			this.Font = new Font("Lexend Deca Medium", 9F);
			this.Size = new Size(300, 40);
			this.BackColor = colorFondo;
			this.Cursor = Cursors.Hand;
			this.Name = $"{tipo}_{++_id}";
			this.Margin = new Padding(2);
			this.Padding = new Padding(0);
			this.Location = new Point(10, 10);
			this.MouseUp += new MouseEventHandler(ordenarBotones);
			this.MouseUp += new MouseEventHandler(actualizarPanel);
			this.Draggable(true);

			// Configurar el TableLayoutPanel
			this.RowCount = 2;
			this.ColumnCount = 2;
			this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this.RowStyles.Add(new RowStyle(SizeType.Percent, 99F));
			this.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));

			// Agregar los controles
			this.Controls.Add(new Etiqueta(nombre), 0, 0);
			Separator separator = new Separator(300, 1);
			this.Controls.Add(separator, 0, 1);
			this.SetColumnSpan(separator, 2);
		}

		public void AgregarControl(Control control)
		{
			this.Controls.Add(control, 1, 0);
			this.SetColumnSpan(control, 1);
		}

		public void SetPosicion(int x, int y)
		{
			this.Location = new Point(x, y);
		}

		public void SetPosicion(Point posicion)
		{
			this.Location = posicion;
		}
	}
}