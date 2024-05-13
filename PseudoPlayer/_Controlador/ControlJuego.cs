using PseudoPlayer._Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace PseudoPlayer
{
	class ControlJuego
	{
		private frm_Player playerWindow;
		private Personaje personaje;
		private List<Keys> teclasPulsadas = new List<Keys>();

		public ControlJuego(frm_Player playerWindow)
		{
			this.playerWindow = playerWindow;
			this.personaje = new Personaje(playerWindow.Width / 2, playerWindow.Height / 2);
			playerWindow.Controls.Add(personaje);
			playerWindow.KeyDown += (sender, e) => TeclaPresionada(e.KeyCode);
			playerWindow.KeyUp += (sender, e) => TeclaSoltada(e.KeyCode);
		}

		public void Iniciar()
		{
			// <INICIO>

		}

		public void TeclaPresionada(Keys keyData)
		{
			if (!teclasPulsadas.Contains(keyData))
			{
				teclasPulsadas.Add(keyData);
			}
		}

		public void TeclaSoltada(Keys keyData)
		{
			teclasPulsadas.Remove(keyData);
		}


		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new frm_Player()); // Iniciar la aplicación
		}
	}
}
