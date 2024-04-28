namespace PseudoBlocks.Controles.Numerico
{
	partial class BloqueXY
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
			nud_Y = new NumericUpDown();
			nud_X = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)nud_Y).BeginInit();
			((System.ComponentModel.ISupportInitialize)nud_X).BeginInit();
			SuspendLayout();
			// 
			// nud_Y
			// 
			nud_Y.Font = new Font("Lexend Deca Medium", 10F);
			nud_Y.Location = new Point(237, 9);
			nud_Y.Margin = new Padding(4);
			nud_Y.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
			nud_Y.Name = "nud_Y";
			nud_Y.Size = new Size(60, 24);
			nud_Y.TabIndex = 7;
			nud_Y.TextAlign = HorizontalAlignment.Center;
			// 
			// nud_X
			// 
			nud_X.Font = new Font("Lexend Deca Medium", 10F);
			nud_X.Location = new Point(168, 9);
			nud_X.Margin = new Padding(4);
			nud_X.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
			nud_X.Name = "nud_X";
			nud_X.Size = new Size(60, 24);
			nud_X.TabIndex = 6;
			nud_X.TextAlign = HorizontalAlignment.Center;
			// 
			// BloqueXY
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(nud_X);
			Controls.Add(nud_Y);
			DoubleBuffered = true;
			Name = "BloqueXY";
			Controls.SetChildIndex(nud_Y, 0);
			Controls.SetChildIndex(nud_X, 0);
			((System.ComponentModel.ISupportInitialize)nud_Y).EndInit();
			((System.ComponentModel.ISupportInitialize)nud_X).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown nud_Y;
		private NumericUpDown nud_X;
	}
}
