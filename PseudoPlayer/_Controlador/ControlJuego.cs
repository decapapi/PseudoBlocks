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
		private Dictionary<Keys, bool> teclasPulsadas = new Dictionary<Keys, bool>();

		public ControlJuego(frm_Player playerWindow)
		{
			this.playerWindow = playerWindow;
			this.personaje = new Personaje(playerWindow.Width / 2, playerWindow.Height / 2);
			playerWindow.Controls.Add(personaje);
		}

		public void Iniciar()
		{
			tickJuego = new System.Threading.Timer(TickJuego, null, 0, 25);
		}

		public void Detener()
		{
			tickJuego.Dispose();
		}

		public void ProcesarInput(ref Message msg, Keys keyData)
		{
			if (msg.Msg == 0x100) // KeyDown
			{
				MessageBox.Show("Tecla presionada: " + keyData.ToString());
			}
			else if (msg.Msg == 0x101) // KeyUp
			{
				MessageBox.Show("Tecla soltada: " + keyData.ToString());
			}
		}

		public void TeclaPresionada(Keys keyData)
		{
			if (!teclasPulsadas.ContainsKey(keyData))
				teclasPulsadas.Add(keyData, true);
			else
				teclasPulsadas[keyData] = true;
		}

		public void TeclaSoltada(Keys keyData)
		{
			teclasPulsadas[keyData] = false;
		}


		private void Actualizar()
		{
			if (playerWindow == null || !playerWindow.IsHandleCreated) return;

			// Lógica de procesamiento de teclas presionadas

			foreach (KeyValuePair<Keys, bool> pair in teclasPulsadas)
			{
				if (pair.Value)
				{
					if (pair.Key == Keys.W)
						personaje.MoverArriba();
					if (pair.Key == Keys.A)
						personaje.MoverIzquierda();
					if (pair.Key == Keys.S)
						personaje.MoverAbajo();
					if (pair.Key == Keys.D)
						personaje.MoverDerecha();
				}
				else
				{
					MessageBox.Show("Tecla soltada: " + pair.Key.ToString());
					teclasPulsadas.Remove(pair.Key);
				}
			}
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
