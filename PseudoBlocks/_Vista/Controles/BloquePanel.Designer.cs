namespace PseudoBlocks.Vista.Controles
{
	partial class BloquePanel
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
			pnl_layout = new Panel();
			SuspendLayout();
			// 
			// pnl_layout
			// 
			pnl_layout.AllowDrop = true;
			pnl_layout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pnl_layout.AutoSize = true;
			pnl_layout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			pnl_layout.BackColor = SystemColors.Window;
			pnl_layout.Location = new Point(5, 36);
			pnl_layout.Margin = new Padding(4, 0, 4, 0);
			pnl_layout.MinimumSize = new Size(315, 8);
			pnl_layout.Name = "pnl_layout";
			pnl_layout.Padding = new Padding(4);
			pnl_layout.Size = new Size(315, 8);
			pnl_layout.TabIndex = 5;
			pnl_layout.DragDrop += DragDrop;
			pnl_layout.DragEnter += DragEnter;
			pnl_layout.DragOver += DragOver;
			// 
			// BloquePanel
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = SystemColors.GradientInactiveCaption;
			Controls.Add(pnl_layout);
			Cursor = Cursors.Hand;
			MaximumSize = new Size(0, 0);
			MinimumSize = new Size(325, 55);
			Name = "BloquePanel";
			Size = new Size(325, 55);
			Controls.SetChildIndex(controlName, 0);
			Controls.SetChildIndex(pnl_layout, 0);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel pnl_layout;
	}
}
