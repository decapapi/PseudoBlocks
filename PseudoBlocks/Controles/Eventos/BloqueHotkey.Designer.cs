namespace PseudoBlocks.Controles.Eventos
{
	partial class BloqueHotkey
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
			btn_seleccionar.Location = new Point(190, 3);
			btn_seleccionar.Margin = new Padding(4);
			btn_seleccionar.Name = "btn_seleccionar";
			btn_seleccionar.Size = new Size(130, 30);
			btn_seleccionar.TabIndex = 7;
			btn_seleccionar.Text = "Seleccionar...";
			btn_seleccionar.UseVisualStyleBackColor = true;
			btn_seleccionar.Click += EstablecerTecla;
			btn_seleccionar.KeyDown += CapturarTecla;
			btn_seleccionar.Leave += CancelarCapturar;
			// 
			// BloqueHotkey
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightCoral;
			Controls.Add(btn_seleccionar);
			MinimumSize = new Size(325, 55);
			Name = "BloqueHotkey";
			Controls.SetChildIndex(controlName, 0);
			Controls.SetChildIndex(btn_seleccionar, 0);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_seleccionar;
	}
}
