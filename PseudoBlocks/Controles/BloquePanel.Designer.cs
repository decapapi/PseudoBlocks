namespace PseudoBlocks.Controles
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
			pnl_layout.Location = new Point(6, 42);
			pnl_layout.Margin = new Padding(5, 0, 5, 0);
			pnl_layout.MinimumSize = new Size(315, 10);
			pnl_layout.Name = "pnl_layout";
			pnl_layout.Padding = new Padding(5);
			pnl_layout.Size = new Size(315, 10);
			pnl_layout.TabIndex = 5;
			pnl_layout.DragDrop += pnl_layout_DragDrop;
			pnl_layout.DragEnter += pnl_layout_DragEnter;
			pnl_layout.DragOver += pnl_layout_DragOver;
			// 
			// BloquePanel
			// 
			AutoScaleDimensions = new SizeF(10F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = SystemColors.GradientInactiveCaption;
			Controls.Add(pnl_layout);
			Cursor = Cursors.Hand;
			MinimumSize = new Size(325, 65);
			Name = "BloquePanel";
			Size = new Size(325, 75);
			Controls.SetChildIndex(pnl_layout, 0);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel pnl_layout;
	}
}
