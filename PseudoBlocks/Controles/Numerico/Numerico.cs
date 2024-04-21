using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks.Controles
{
	class Numerico : NumericUpDown
	{
		public Numerico(bool decimales = false) 
		{ 
			this.BackColor = SystemColors.Control;
			this.Font = new Font("Lexend Deca Medium", 9F);
			this.Cursor = Cursors.Hand;
			this.TextAlign = HorizontalAlignment.Center;
			this.DecimalPlaces = decimales ? 2 : 0;
			this.Increment = 1;
			this.Minimum = 0;
			this.Maximum = decimales ? new decimal(99999.99) : 99999;
			this.Anchor = AnchorStyles.Right;
			this.Margin = new Padding(8);
			this.Size = new Size(100, 22);
		}
	}
}
