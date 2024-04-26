using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks.Controles
{
	class FilePicker : Button
	{
		protected string archivo = string.Empty;

		public FilePicker() 
		{
			this.Text = "Seleccionar";
			this.BackColor = SystemColors.Control;
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = 0;
			this.Font = new Font("Lexend Deca Medium", 8F);
			this.Cursor = Cursors.Hand;
			this.TextAlign = ContentAlignment.MiddleLeft;
			this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.Dock = DockStyle.Right;
			this.Size = new Size(100, 22);
			this.Padding = new Padding(0);
			this.Margin = new Padding(8);
			this.AutoEllipsis = true;
		}

		public string GetArchivo()
		{
			return this.archivo;
		}
	}
}
