using PseudoPlayer._Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoPlayer
{
	class ControlJuego
	{
		private frm_Player playerWindow;
		private Personaje personaje;
		private System.Threading.Timer tickJuego;
		private List<Keys> teclasPulsadas = new List<Keys>();

		public ControlJuego(frm_Player playerWindow)
		{
			this.playerWindow = playerWindow;
			this.personaje = new Personaje(playerWindow.Width / 2, playerWindow.Height / 2);
			playerWindow.Controls.Add(personaje);
			playerWindow.KeyDown += (sender, e) => TeclaPresionada(e.KeyCode);
			playerWindow.KeyUp += (sender, e) => TeclaSoltada(e.KeyCode);
			playerWindow.FormClosing += (sender, e) => Detener();
		}

		public void Iniciar()
		{
			tickJuego = new System.Threading.Timer(TickJuego, null, 0, 1);

			// <INICIO>

		}

		private void Actualizar()
		{
			if (playerWindow == null || !playerWindow.IsHandleCreated) return;

			// <ACTUALIZAR>

			teclasPulsadas.ForEach(tecla =>
			{
				switch (tecla.GetHashCode())
				{
					// <PULSAR>
					
				}
			});
		}

		public void Detener()
		{
			tickJuego?.Dispose();
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

		private void TickJuego(object state)
		{
			if (playerWindow == null || !playerWindow.IsHandleCreated || playerWindow.IsDisposed) return;

			try
			{
				playerWindow.Invoke((MethodInvoker)delegate {
					Actualizar();
				});
			}
			catch (ObjectDisposedException) // Si el formulario se cierra
			{
				this.Detener();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error inesperado!: " + ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Detener();
			}
		}

		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new frm_Player()); // Iniciar la aplicación
		}
	}
}
