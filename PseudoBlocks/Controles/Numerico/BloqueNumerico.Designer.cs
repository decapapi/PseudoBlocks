﻿namespace PseudoBlocks.Controles.Numerico
{
	partial class BloqueNumerico
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
			nud_num = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)nud_num).BeginInit();
			SuspendLayout();
			// 
			// nud_num
			// 
			nud_num.Font = new Font("Lexend Deca Medium", 10F);
			nud_num.Location = new Point(196, 9);
			nud_num.Margin = new Padding(4);
			nud_num.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			nud_num.Name = "nud_num";
			nud_num.Size = new Size(100, 24);
			nud_num.TabIndex = 5;
			nud_num.TextAlign = HorizontalAlignment.Center;
			// 
			// BloqueNumerico
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(nud_num);
			DoubleBuffered = true;
			Name = "BloqueNumerico";
			Controls.SetChildIndex(nud_num, 0);
			((System.ComponentModel.ISupportInitialize)nud_num).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown nud_num;
	}
}