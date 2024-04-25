﻿namespace PseudoBlocks.Controles
{
	partial class Bloque
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
			controlName = new Label();
			bloque_menu = new ContextMenuStrip(components);
			eliminarToolStripMenuItem = new ToolStripMenuItem();
			bloque_menu.SuspendLayout();
			SuspendLayout();
			// 
			// controlName
			// 
			controlName.AutoSize = true;
			controlName.Dock = DockStyle.Top;
			controlName.Enabled = false;
			controlName.Font = new Font("Lexend Deca Medium", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
			controlName.Location = new Point(0, 0);
			controlName.Margin = new Padding(0);
			controlName.Name = "controlName";
			controlName.Padding = new Padding(10, 10, 0, 0);
			controlName.Size = new Size(144, 31);
			controlName.TabIndex = 2;
			controlName.Text = "Nombre del control";
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
			// Bloque
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.Tan;
			Controls.Add(controlName);
			Font = new Font("Lexend Deca Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(0);
			Name = "Bloque";
			Size = new Size(305, 42);
			bloque_menu.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label controlName;
		private ContextMenuStrip bloque_menu;
		private ToolStripMenuItem eliminarToolStripMenuItem;
	}
}