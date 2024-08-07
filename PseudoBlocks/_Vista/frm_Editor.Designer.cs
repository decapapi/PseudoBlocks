﻿namespace PseudoBlocks.Vista
{
	partial class frm_Editor
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Editor));
			top_menu = new MenuStrip();
			archivoToolStripMenuItem = new ToolStripMenuItem();
			tsm_item_archivo_exportar = new ToolStripMenuItem();
			toolStripSeparator5 = new ToolStripSeparator();
			tsm_item_archivo_abrir = new ToolStripMenuItem();
			toolStripSeparator = new ToolStripSeparator();
			tsm_item_archivo_guardar = new ToolStripMenuItem();
			tsm_item_archivo_guardar_como = new ToolStripMenuItem();
			herramientasToolStripMenuItem = new ToolStripMenuItem();
			opcionesToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			acercadeToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			salirToolStripMenuItem = new ToolStripMenuItem();
			pnl_layout_principal = new Panel();
			pnl_eventos = new FlowLayoutPanel();
			lbl_eventos = new Label();
			btn_event_onload = new Button();
			btn_event_onpress = new Button();
			pnl_sonido = new FlowLayoutPanel();
			lbl_sonido = new Label();
			btn_sound_play = new Button();
			btn_sound_playLoop = new Button();
			pnl_escenario = new FlowLayoutPanel();
			lbl_escenario = new Label();
			btn_change_background = new Button();
			btn_change_character = new Button();
			btn_change_size = new Button();
			pnl_logica = new FlowLayoutPanel();
			lbl_logica = new Label();
			btn_logic_wait = new Button();
			btn_logic_repeat = new Button();
			btn_logic_stopRepeating = new Button();
			pnl_movimiento = new FlowLayoutPanel();
			lbl_movimiento = new Label();
			btn_move_up = new Button();
			btn_move_down = new Button();
			btn_move_left = new Button();
			btn_move_right = new Button();
			btn_move_to = new Button();
			pnl_components = new FlowLayoutPanel();
			flowLayoutPanel2 = new FlowLayoutPanel();
			btn_movimiento = new Button();
			btn_escenario = new Button();
			btn_sonido = new Button();
			btn_logica = new Button();
			btn_eventos = new Button();
			top_menu.SuspendLayout();
			pnl_eventos.SuspendLayout();
			pnl_sonido.SuspendLayout();
			pnl_escenario.SuspendLayout();
			pnl_logica.SuspendLayout();
			pnl_movimiento.SuspendLayout();
			pnl_components.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// top_menu
			// 
			top_menu.BackColor = SystemColors.Window;
			resources.ApplyResources(top_menu, "top_menu");
			top_menu.ImageScalingSize = new Size(20, 20);
			top_menu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, herramientasToolStripMenuItem });
			top_menu.Name = "top_menu";
			// 
			// archivoToolStripMenuItem
			// 
			archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsm_item_archivo_exportar, toolStripSeparator5, tsm_item_archivo_abrir, toolStripSeparator, tsm_item_archivo_guardar, tsm_item_archivo_guardar_como });
			archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			resources.ApplyResources(archivoToolStripMenuItem, "archivoToolStripMenuItem");
			// 
			// tsm_item_archivo_exportar
			// 
			tsm_item_archivo_exportar.Image = Properties.Resources.exportar;
			resources.ApplyResources(tsm_item_archivo_exportar, "tsm_item_archivo_exportar");
			tsm_item_archivo_exportar.Name = "tsm_item_archivo_exportar";
			tsm_item_archivo_exportar.Click += ExportarProyecto;
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
			// 
			// tsm_item_archivo_abrir
			// 
			resources.ApplyResources(tsm_item_archivo_abrir, "tsm_item_archivo_abrir");
			tsm_item_archivo_abrir.Name = "tsm_item_archivo_abrir";
			tsm_item_archivo_abrir.Click += AbrirProyecto;
			// 
			// toolStripSeparator
			// 
			toolStripSeparator.Name = "toolStripSeparator";
			resources.ApplyResources(toolStripSeparator, "toolStripSeparator");
			// 
			// tsm_item_archivo_guardar
			// 
			resources.ApplyResources(tsm_item_archivo_guardar, "tsm_item_archivo_guardar");
			tsm_item_archivo_guardar.Name = "tsm_item_archivo_guardar";
			tsm_item_archivo_guardar.Click += Guardar;
			// 
			// tsm_item_archivo_guardar_como
			// 
			resources.ApplyResources(tsm_item_archivo_guardar_como, "tsm_item_archivo_guardar_como");
			tsm_item_archivo_guardar_como.Name = "tsm_item_archivo_guardar_como";
			tsm_item_archivo_guardar_como.Click += GuardarProyecto;
			// 
			// herramientasToolStripMenuItem
			// 
			herramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, toolStripSeparator1, acercadeToolStripMenuItem, toolStripSeparator2, salirToolStripMenuItem });
			herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			resources.ApplyResources(herramientasToolStripMenuItem, "herramientasToolStripMenuItem");
			// 
			// opcionesToolStripMenuItem
			// 
			opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			resources.ApplyResources(opcionesToolStripMenuItem, "opcionesToolStripMenuItem");
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
			// 
			// acercadeToolStripMenuItem
			// 
			acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
			resources.ApplyResources(acercadeToolStripMenuItem, "acercadeToolStripMenuItem");
			acercadeToolStripMenuItem.Click += MostrarAboutBox;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
			// 
			// salirToolStripMenuItem
			// 
			salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			resources.ApplyResources(salirToolStripMenuItem, "salirToolStripMenuItem");
			salirToolStripMenuItem.Click += Cerrar;
			// 
			// pnl_layout_principal
			// 
			pnl_layout_principal.AllowDrop = true;
			resources.ApplyResources(pnl_layout_principal, "pnl_layout_principal");
			pnl_layout_principal.BackColor = SystemColors.Window;
			pnl_layout_principal.Name = "pnl_layout_principal";
			// 
			// pnl_eventos
			// 
			resources.ApplyResources(pnl_eventos, "pnl_eventos");
			pnl_eventos.BackColor = SystemColors.Window;
			pnl_eventos.Controls.Add(lbl_eventos);
			pnl_eventos.Controls.Add(btn_event_onload);
			pnl_eventos.Controls.Add(btn_event_onpress);
			pnl_eventos.Name = "pnl_eventos";
			// 
			// lbl_eventos
			// 
			resources.ApplyResources(lbl_eventos, "lbl_eventos");
			lbl_eventos.Name = "lbl_eventos";
			// 
			// btn_event_onload
			// 
			btn_event_onload.BackColor = Color.LightCoral;
			btn_event_onload.Cursor = Cursors.Hand;
			btn_event_onload.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_event_onload, "btn_event_onload");
			btn_event_onload.Name = "btn_event_onload";
			btn_event_onload.Tag = "";
			btn_event_onload.UseMnemonic = false;
			btn_event_onload.UseVisualStyleBackColor = false;
			btn_event_onload.Click += AgregarBloque;
			// 
			// btn_event_onpress
			// 
			btn_event_onpress.BackColor = Color.LightCoral;
			btn_event_onpress.Cursor = Cursors.Hand;
			btn_event_onpress.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_event_onpress, "btn_event_onpress");
			btn_event_onpress.Name = "btn_event_onpress";
			btn_event_onpress.Tag = "";
			btn_event_onpress.UseMnemonic = false;
			btn_event_onpress.UseVisualStyleBackColor = false;
			btn_event_onpress.Click += AgregarBloque;
			// 
			// pnl_sonido
			// 
			resources.ApplyResources(pnl_sonido, "pnl_sonido");
			pnl_sonido.BackColor = SystemColors.Window;
			pnl_sonido.Controls.Add(lbl_sonido);
			pnl_sonido.Controls.Add(btn_sound_play);
			pnl_sonido.Controls.Add(btn_sound_playLoop);
			pnl_sonido.Name = "pnl_sonido";
			// 
			// lbl_sonido
			// 
			resources.ApplyResources(lbl_sonido, "lbl_sonido");
			lbl_sonido.Name = "lbl_sonido";
			// 
			// btn_sound_play
			// 
			btn_sound_play.BackColor = Color.FromArgb(255, 192, 255);
			btn_sound_play.Cursor = Cursors.Hand;
			btn_sound_play.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_sound_play, "btn_sound_play");
			btn_sound_play.Name = "btn_sound_play";
			btn_sound_play.Tag = "";
			btn_sound_play.UseMnemonic = false;
			btn_sound_play.UseVisualStyleBackColor = false;
			btn_sound_play.Click += AgregarBloque;
			// 
			// btn_sound_playLoop
			// 
			btn_sound_playLoop.BackColor = Color.FromArgb(255, 192, 255);
			btn_sound_playLoop.Cursor = Cursors.Hand;
			btn_sound_playLoop.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_sound_playLoop, "btn_sound_playLoop");
			btn_sound_playLoop.Name = "btn_sound_playLoop";
			btn_sound_playLoop.Tag = "";
			btn_sound_playLoop.UseMnemonic = false;
			btn_sound_playLoop.UseVisualStyleBackColor = false;
			btn_sound_playLoop.Click += AgregarBloque;
			// 
			// pnl_escenario
			// 
			resources.ApplyResources(pnl_escenario, "pnl_escenario");
			pnl_escenario.BackColor = SystemColors.Window;
			pnl_escenario.Controls.Add(lbl_escenario);
			pnl_escenario.Controls.Add(btn_change_background);
			pnl_escenario.Controls.Add(btn_change_character);
			pnl_escenario.Controls.Add(btn_change_size);
			pnl_escenario.Name = "pnl_escenario";
			// 
			// lbl_escenario
			// 
			resources.ApplyResources(lbl_escenario, "lbl_escenario");
			lbl_escenario.Name = "lbl_escenario";
			// 
			// btn_change_background
			// 
			btn_change_background.BackColor = Color.LightBlue;
			btn_change_background.Cursor = Cursors.Hand;
			btn_change_background.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_change_background, "btn_change_background");
			btn_change_background.Name = "btn_change_background";
			btn_change_background.Tag = "";
			btn_change_background.UseMnemonic = false;
			btn_change_background.UseVisualStyleBackColor = false;
			btn_change_background.Click += AgregarBloque;
			// 
			// btn_change_character
			// 
			btn_change_character.BackColor = Color.LightBlue;
			btn_change_character.Cursor = Cursors.Hand;
			btn_change_character.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_change_character, "btn_change_character");
			btn_change_character.Name = "btn_change_character";
			btn_change_character.Tag = "";
			btn_change_character.UseMnemonic = false;
			btn_change_character.UseVisualStyleBackColor = false;
			btn_change_character.Click += AgregarBloque;
			// 
			// btn_change_size
			// 
			btn_change_size.BackColor = Color.LightBlue;
			btn_change_size.Cursor = Cursors.Hand;
			btn_change_size.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_change_size, "btn_change_size");
			btn_change_size.Name = "btn_change_size";
			btn_change_size.Tag = "";
			btn_change_size.UseMnemonic = false;
			btn_change_size.UseVisualStyleBackColor = false;
			btn_change_size.Click += AgregarBloque;
			// 
			// pnl_logica
			// 
			resources.ApplyResources(pnl_logica, "pnl_logica");
			pnl_logica.BackColor = SystemColors.Window;
			pnl_logica.Controls.Add(lbl_logica);
			pnl_logica.Controls.Add(btn_logic_wait);
			pnl_logica.Controls.Add(btn_logic_repeat);
			pnl_logica.Controls.Add(btn_logic_stopRepeating);
			pnl_logica.Name = "pnl_logica";
			// 
			// lbl_logica
			// 
			resources.ApplyResources(lbl_logica, "lbl_logica");
			lbl_logica.Name = "lbl_logica";
			// 
			// btn_logic_wait
			// 
			btn_logic_wait.BackColor = Color.LightSalmon;
			btn_logic_wait.Cursor = Cursors.Hand;
			btn_logic_wait.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_logic_wait, "btn_logic_wait");
			btn_logic_wait.Name = "btn_logic_wait";
			btn_logic_wait.Tag = "";
			btn_logic_wait.UseMnemonic = false;
			btn_logic_wait.UseVisualStyleBackColor = false;
			btn_logic_wait.Click += AgregarBloque;
			// 
			// btn_logic_repeat
			// 
			btn_logic_repeat.BackColor = Color.LightSalmon;
			btn_logic_repeat.Cursor = Cursors.Hand;
			btn_logic_repeat.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_logic_repeat, "btn_logic_repeat");
			btn_logic_repeat.Name = "btn_logic_repeat";
			btn_logic_repeat.Tag = "";
			btn_logic_repeat.UseMnemonic = false;
			btn_logic_repeat.UseVisualStyleBackColor = false;
			btn_logic_repeat.Click += AgregarBloque;
			// 
			// btn_logic_stopRepeating
			// 
			btn_logic_stopRepeating.BackColor = Color.LightSalmon;
			btn_logic_stopRepeating.Cursor = Cursors.Hand;
			btn_logic_stopRepeating.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_logic_stopRepeating, "btn_logic_stopRepeating");
			btn_logic_stopRepeating.Name = "btn_logic_stopRepeating";
			btn_logic_stopRepeating.Tag = "";
			btn_logic_stopRepeating.UseMnemonic = false;
			btn_logic_stopRepeating.UseVisualStyleBackColor = false;
			btn_logic_stopRepeating.Click += AgregarBloque;
			// 
			// pnl_movimiento
			// 
			resources.ApplyResources(pnl_movimiento, "pnl_movimiento");
			pnl_movimiento.BackColor = SystemColors.Window;
			pnl_movimiento.Controls.Add(lbl_movimiento);
			pnl_movimiento.Controls.Add(btn_move_up);
			pnl_movimiento.Controls.Add(btn_move_down);
			pnl_movimiento.Controls.Add(btn_move_left);
			pnl_movimiento.Controls.Add(btn_move_right);
			pnl_movimiento.Controls.Add(btn_move_to);
			pnl_movimiento.Name = "pnl_movimiento";
			// 
			// lbl_movimiento
			// 
			resources.ApplyResources(lbl_movimiento, "lbl_movimiento");
			lbl_movimiento.Name = "lbl_movimiento";
			// 
			// btn_move_up
			// 
			btn_move_up.BackColor = Color.MediumAquamarine;
			btn_move_up.Cursor = Cursors.Hand;
			btn_move_up.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_move_up, "btn_move_up");
			btn_move_up.Name = "btn_move_up";
			btn_move_up.Tag = "";
			btn_move_up.UseMnemonic = false;
			btn_move_up.UseVisualStyleBackColor = false;
			btn_move_up.Click += AgregarBloque;
			// 
			// btn_move_down
			// 
			btn_move_down.BackColor = Color.MediumAquamarine;
			btn_move_down.Cursor = Cursors.Hand;
			btn_move_down.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_move_down, "btn_move_down");
			btn_move_down.Name = "btn_move_down";
			btn_move_down.Tag = "";
			btn_move_down.UseMnemonic = false;
			btn_move_down.UseVisualStyleBackColor = false;
			btn_move_down.Click += AgregarBloque;
			// 
			// btn_move_left
			// 
			btn_move_left.BackColor = Color.MediumAquamarine;
			btn_move_left.Cursor = Cursors.Hand;
			btn_move_left.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_move_left, "btn_move_left");
			btn_move_left.Name = "btn_move_left";
			btn_move_left.Tag = "";
			btn_move_left.UseMnemonic = false;
			btn_move_left.UseVisualStyleBackColor = false;
			btn_move_left.Click += AgregarBloque;
			// 
			// btn_move_right
			// 
			btn_move_right.BackColor = Color.MediumAquamarine;
			btn_move_right.Cursor = Cursors.Hand;
			btn_move_right.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_move_right, "btn_move_right");
			btn_move_right.Name = "btn_move_right";
			btn_move_right.Tag = "";
			btn_move_right.UseMnemonic = false;
			btn_move_right.UseVisualStyleBackColor = false;
			btn_move_right.Click += AgregarBloque;
			// 
			// btn_move_to
			// 
			btn_move_to.BackColor = Color.MediumAquamarine;
			btn_move_to.Cursor = Cursors.Hand;
			btn_move_to.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(btn_move_to, "btn_move_to");
			btn_move_to.Name = "btn_move_to";
			btn_move_to.Tag = "";
			btn_move_to.UseMnemonic = false;
			btn_move_to.UseVisualStyleBackColor = false;
			btn_move_to.Click += AgregarBloque;
			// 
			// pnl_components
			// 
			resources.ApplyResources(pnl_components, "pnl_components");
			pnl_components.BackColor = SystemColors.Window;
			pnl_components.Controls.Add(pnl_movimiento);
			pnl_components.Controls.Add(pnl_escenario);
			pnl_components.Controls.Add(pnl_sonido);
			pnl_components.Controls.Add(pnl_logica);
			pnl_components.Controls.Add(pnl_eventos);
			pnl_components.Name = "pnl_components";
			pnl_components.Paint += CambiarCategoria;
			// 
			// flowLayoutPanel2
			// 
			resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
			flowLayoutPanel2.BackColor = SystemColors.Window;
			flowLayoutPanel2.Controls.Add(btn_movimiento);
			flowLayoutPanel2.Controls.Add(btn_escenario);
			flowLayoutPanel2.Controls.Add(btn_sonido);
			flowLayoutPanel2.Controls.Add(btn_logica);
			flowLayoutPanel2.Controls.Add(btn_eventos);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			// 
			// btn_movimiento
			// 
			btn_movimiento.BackColor = SystemColors.Window;
			resources.ApplyResources(btn_movimiento, "btn_movimiento");
			btn_movimiento.Cursor = Cursors.Hand;
			btn_movimiento.FlatAppearance.BorderSize = 0;
			btn_movimiento.FlatAppearance.CheckedBackColor = SystemColors.Window;
			btn_movimiento.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
			btn_movimiento.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
			btn_movimiento.Image = Properties.Resources.circle_1;
			btn_movimiento.Name = "btn_movimiento";
			btn_movimiento.Tag = "";
			btn_movimiento.UseMnemonic = false;
			btn_movimiento.UseVisualStyleBackColor = false;
			btn_movimiento.Click += CambiarCategoria;
			// 
			// btn_escenario
			// 
			btn_escenario.BackColor = SystemColors.Window;
			resources.ApplyResources(btn_escenario, "btn_escenario");
			btn_escenario.Cursor = Cursors.Hand;
			btn_escenario.FlatAppearance.BorderSize = 0;
			btn_escenario.FlatAppearance.CheckedBackColor = SystemColors.Window;
			btn_escenario.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
			btn_escenario.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
			btn_escenario.Image = Properties.Resources.circle_2;
			btn_escenario.Name = "btn_escenario";
			btn_escenario.Tag = "";
			btn_escenario.UseMnemonic = false;
			btn_escenario.UseVisualStyleBackColor = false;
			btn_escenario.Click += CambiarCategoria;
			// 
			// btn_sonido
			// 
			btn_sonido.BackColor = SystemColors.Window;
			resources.ApplyResources(btn_sonido, "btn_sonido");
			btn_sonido.Cursor = Cursors.Hand;
			btn_sonido.FlatAppearance.BorderSize = 0;
			btn_sonido.FlatAppearance.CheckedBackColor = SystemColors.Window;
			btn_sonido.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
			btn_sonido.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
			btn_sonido.Image = Properties.Resources.circle_3;
			btn_sonido.Name = "btn_sonido";
			btn_sonido.Tag = "";
			btn_sonido.UseMnemonic = false;
			btn_sonido.UseVisualStyleBackColor = false;
			btn_sonido.Click += CambiarCategoria;
			// 
			// btn_logica
			// 
			btn_logica.BackColor = SystemColors.Window;
			resources.ApplyResources(btn_logica, "btn_logica");
			btn_logica.Cursor = Cursors.Hand;
			btn_logica.FlatAppearance.BorderSize = 0;
			btn_logica.FlatAppearance.CheckedBackColor = SystemColors.Window;
			btn_logica.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
			btn_logica.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
			btn_logica.Image = Properties.Resources.circle_4;
			btn_logica.Name = "btn_logica";
			btn_logica.Tag = "";
			btn_logica.UseMnemonic = false;
			btn_logica.UseVisualStyleBackColor = false;
			btn_logica.Click += CambiarCategoria;
			// 
			// btn_eventos
			// 
			btn_eventos.BackColor = SystemColors.Window;
			resources.ApplyResources(btn_eventos, "btn_eventos");
			btn_eventos.Cursor = Cursors.Hand;
			btn_eventos.FlatAppearance.BorderSize = 0;
			btn_eventos.FlatAppearance.CheckedBackColor = SystemColors.Window;
			btn_eventos.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
			btn_eventos.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
			btn_eventos.Image = Properties.Resources.circle_5;
			btn_eventos.Name = "btn_eventos";
			btn_eventos.Tag = "";
			btn_eventos.UseMnemonic = false;
			btn_eventos.UseVisualStyleBackColor = false;
			btn_eventos.Click += CambiarCategoria;
			// 
			// frm_Editor
			// 
			AutoScaleMode = AutoScaleMode.None;
			resources.ApplyResources(this, "$this");
			Controls.Add(flowLayoutPanel2);
			Controls.Add(top_menu);
			Controls.Add(pnl_components);
			Controls.Add(pnl_layout_principal);
			DoubleBuffered = true;
			MainMenuStrip = top_menu;
			Name = "frm_Editor";
			top_menu.ResumeLayout(false);
			top_menu.PerformLayout();
			pnl_eventos.ResumeLayout(false);
			pnl_eventos.PerformLayout();
			pnl_sonido.ResumeLayout(false);
			pnl_sonido.PerformLayout();
			pnl_escenario.ResumeLayout(false);
			pnl_escenario.PerformLayout();
			pnl_logica.ResumeLayout(false);
			pnl_logica.PerformLayout();
			pnl_movimiento.ResumeLayout(false);
			pnl_movimiento.PerformLayout();
			pnl_components.ResumeLayout(false);
			pnl_components.PerformLayout();
			flowLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip top_menu;
		private ToolStripMenuItem archivoToolStripMenuItem;
		private ToolStripMenuItem tsm_item_archivo_exportar;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripMenuItem tsm_item_archivo_guardar_como;
		private ToolStripMenuItem herramientasToolStripMenuItem;
		private ToolStripMenuItem opcionesToolStripMenuItem;
		private ToolStripMenuItem tsm_item_archivo_abrir;
		private ToolStripSeparator toolStripSeparator5;
		private Panel pnl_layout_principal;
		private FlowLayoutPanel pnl_eventos;
		private Label lbl_eventos;
		private Button btn_event_onload;
		private Button btn_event_onpress;
		private FlowLayoutPanel pnl_sonido;
		private Label lbl_sonido;
		private Button btn_sound_play;
		private FlowLayoutPanel pnl_escenario;
		private Button btn_change_background;
		private Button btn_change_character;
		private FlowLayoutPanel pnl_logica;
		private Label lbl_logica;
		private Button btn_logic_wait;
		private Button btn_logic_repeat;
		private FlowLayoutPanel pnl_movimiento;
		private Button btn_move_right;
		private Button btn_move_left;
		private Button btn_move_up;
		private Button btn_move_down;
		private FlowLayoutPanel pnl_components;
		private FlowLayoutPanel flowLayoutPanel2;
		private Button btn_movimiento;
		private Button btn_escenario;
		private Button btn_sonido;
		private Button btn_logica;
		private Button btn_eventos;
		private Label lbl_escenario;
		private Label lbl_movimiento;
		private Button btn_change_size;
		private ToolStripMenuItem tsm_item_archivo_guardar;
		private ToolStripMenuItem acercadeToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem salirToolStripMenuItem;
		private Button btn_move_to;
		private Button btn_logic_stopRepeating;
		private Button btn_sound_playLoop;
	}
}
