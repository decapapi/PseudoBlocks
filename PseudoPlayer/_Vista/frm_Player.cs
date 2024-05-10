﻿using System;
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

		public void CambiarFondo(Image imagen)
		{
			this.BackgroundImage = imagen;
		}

		public void ReproducirSonido(string ruta)
		{
			System.Media.SoundPlayer sp = new System.Media.SoundPlayer(ruta);
			sp.Play();
		}
	}
}
