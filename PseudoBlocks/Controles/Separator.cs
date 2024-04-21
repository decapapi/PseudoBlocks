using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PseudoBlocks.Controles
{
	class Separator : Panel
	{
		public Separator(int sizeX, int sizeY)
		{
			this.Size = new Size(sizeX, sizeY);
			this.BackColor = Color.Black;
			this.Enabled = false;
			this.Margin = new Padding(0);
			this.Padding = new Padding(0);
		}
	}
}
