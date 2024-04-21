using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks.Controles
{
	class Etiqueta : Label
	{
		public Etiqueta(string texto) 
		{
			this.Text = texto;
			this.Margin = new Padding(10);
			this.TextAlign = ContentAlignment.MiddleCenter;
			this.AutoSize = true;
			this.Anchor = AnchorStyles.Left;
			this.Font = new Font("Lexend Deca Medium", 9F);
			this.CausesValidation = false;
			this.Enabled = false;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			// Redefinir como se pinta para evitar cambiar al color de desactivado
				TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, 
					SystemColors.ControlText, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
		}
	}
}
