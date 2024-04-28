namespace PseudoBlocks.Controles.Archivos
{
	partial class BloqueAudio
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
			btn_seleccionar = new Button();
			SuspendLayout();
			// 
			// btn_seleccionar
			// 
			btn_seleccionar.Location = new Point(171, 6);
			btn_seleccionar.Margin = new Padding(4);
			btn_seleccionar.Name = "btn_seleccionar";
			btn_seleccionar.Size = new Size(130, 30);
			btn_seleccionar.TabIndex = 5;
			btn_seleccionar.Text = "Seleccionar...";
			btn_seleccionar.UseVisualStyleBackColor = true;
			btn_seleccionar.Click += SeleccionarArchivo;
			// 
			// BloqueAudio
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 192, 255);
			Controls.Add(btn_seleccionar);
			Name = "BloqueAudio";
			Controls.SetChildIndex(btn_seleccionar, 0);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_seleccionar;
	}
}
