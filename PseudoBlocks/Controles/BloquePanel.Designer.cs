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
			components = new System.ComponentModel.Container();
			bloque_menu = new ContextMenuStrip(components);
			eliminarToolStripMenuItem = new ToolStripMenuItem();
			pnl_layout = new Panel();
			nombreControl = new Label();
			bloque_menu.SuspendLayout();
			SuspendLayout();
			// 
			// bloque_menu
			// 
			bloque_menu.Font = new Font("Lexend Deca Medium", 9F);
			bloque_menu.ImageScalingSize = new Size(20, 20);
			bloque_menu.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
			bloque_menu.Name = "menu_control";
			bloque_menu.Size = new Size(128, 28);
			bloque_menu.Text = "Ordenar";
			// 
			// eliminarToolStripMenuItem
			// 
			eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			eliminarToolStripMenuItem.Size = new Size(127, 24);
			eliminarToolStripMenuItem.Text = "Eliminar";
			// 
			// pnl_layout
			// 
			pnl_layout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pnl_layout.AutoSize = true;
			pnl_layout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			pnl_layout.BackColor = SystemColors.GradientInactiveCaption;
			pnl_layout.Location = new Point(0, 42);
			pnl_layout.Margin = new Padding(0);
			pnl_layout.MaximumSize = new Size(325, 999999999);
			pnl_layout.MinimumSize = new Size(325, 0);
			pnl_layout.Name = "pnl_layout";
			pnl_layout.Padding = new Padding(10, 0, 10, 10);
			pnl_layout.Size = new Size(325, 10);
			pnl_layout.TabIndex = 3;
			// 
			// nombreControl
			// 
			nombreControl.AutoSize = true;
			nombreControl.Dock = DockStyle.Top;
			nombreControl.Enabled = false;
			nombreControl.Font = new Font("Lexend Deca Medium", 9.5F);
			nombreControl.Location = new Point(0, 0);
			nombreControl.Margin = new Padding(0);
			nombreControl.Name = "nombreControl";
			nombreControl.Padding = new Padding(10, 10, 0, 0);
			nombreControl.Size = new Size(144, 31);
			nombreControl.TabIndex = 4;
			nombreControl.Text = "Nombre del control";
			// 
			// BloquePanel
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = SystemColors.GradientInactiveCaption;
			Controls.Add(nombreControl);
			Controls.Add(pnl_layout);
			Font = new Font("Lexend Deca Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(0);
			Name = "BloquePanel";
			Size = new Size(325, 52);
			bloque_menu.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ContextMenuStrip bloque_menu;
		private ToolStripMenuItem eliminarToolStripMenuItem;
		private Panel pnl_layout;
		private Label nombreControl;
	}
}
