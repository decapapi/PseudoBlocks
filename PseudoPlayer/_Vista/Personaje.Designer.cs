namespace PseudoPlayer._Vista
{
	partial class Personaje
	{
		/// <summary> 
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			SuspendLayout();
			// 
			// Personaje
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Transparent;
			BackgroundImage = Properties.Resources.Adnix_Animation;
			BackgroundImageLayout = ImageLayout.Zoom;
			DoubleBuffered = true;
			Margin = new Padding(0);
			MaximumSize = new Size(100, 100);
			MinimumSize = new Size(100, 100);
			Name = "Personaje";
			Size = new Size(100, 100);
			ResumeLayout(false);
		}

		#endregion
	}
}
