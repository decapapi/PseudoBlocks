using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoPlayer
{
	public partial class frm_Player : Form
	{
		private ControlJuego cj;

		public frm_Player()
		{
			InitializeComponent();
			cj = new ControlJuego(this);
			cj.Iniciar();
		}
	}
}
