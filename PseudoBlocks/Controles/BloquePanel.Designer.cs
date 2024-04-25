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
			nombreControl = new Label();
			pnl_layout = new Panel();
			panel1 = new Panel();
			bloque_menu.SuspendLayout();
			SuspendLayout();
			// 
			// bloque_menu
			// 
			bloque_menu.Font = new Font("Lexend Deca Medium", 9F);
			bloque_menu.ImageScalingSize = new Size(20, 20);
			bloque_menu.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
			bloque_menu.Name = "menu_control";
			bloque_menu.Size = new Size(141, 32);
			bloque_menu.Text = "Ordenar";
			// 
			// eliminarToolStripMenuItem
			// 
			eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			eliminarToolStripMenuItem.Size = new Size(140, 28);
			eliminarToolStripMenuItem.Text = "Eliminar";
			eliminarToolStripMenuItem.Click += EliminarComponente;
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
			nombreControl.Size = new Size(175, 35);
			nombreControl.TabIndex = 4;
			nombreControl.Text = "Nombre del control";
			// 
			// pnl_layout
			// 
			pnl_layout.AllowDrop = true;
			pnl_layout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pnl_layout.AutoSize = true;
			pnl_layout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			pnl_layout.BackColor = SystemColors.Window;
			pnl_layout.Location = new Point(5, 46);
			pnl_layout.Margin = new Padding(5, 0, 5, 0);
			pnl_layout.MaximumSize = new Size(315, 999999999);
			pnl_layout.MinimumSize = new Size(315, 0);
			pnl_layout.Name = "pnl_layout";
			pnl_layout.Padding = new Padding(0, 5, 0, 5);
			pnl_layout.Size = new Size(315, 10);
			pnl_layout.TabIndex = 5;
			pnl_layout.DragDrop += pnl_layout_DragDrop;
			pnl_layout.DragEnter += pnl_layout_DragEnter;
			pnl_layout.DragOver += pnl_layout_DragOver;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Black;
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 70);
			panel1.Margin = new Padding(0);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(0, 0, 0, 5);
			panel1.Size = new Size(325, 2);
			panel1.TabIndex = 3;
			// 
			// BloquePanel
			// 
			AutoScaleDimensions = new SizeF(10F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = SystemColors.GradientInactiveCaption;
			Controls.Add(pnl_layout);
			Controls.Add(panel1);
			Controls.Add(nombreControl);
			Cursor = Cursors.Hand;
			Font = new Font("Lexend Deca Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(0);
			MaximumSize = new Size(325, 999999999);
			MinimumSize = new Size(325, 70);
			Name = "BloquePanel";
			Size = new Size(325, 72);
			bloque_menu.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ContextMenuStrip bloque_menu;
		private ToolStripMenuItem eliminarToolStripMenuItem;
		private Label nombreControl;
		private Panel pnl_layout;
		private Panel panel1;
	}
}
