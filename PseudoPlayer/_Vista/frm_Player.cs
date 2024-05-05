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

		private void frm_Player_FormClosing(object sender, FormClosingEventArgs e)
		{
			cj.Detener();
		}

		private void TeclaPresionada(object sender, KeyEventArgs e)
		{
			cj.TeclaPresionada(e.KeyCode);
		}

		private void TeclaSoltada(object sender, KeyEventArgs e)
		{
			cj.TeclaSoltada(e.KeyCode);
		}
	}
}
