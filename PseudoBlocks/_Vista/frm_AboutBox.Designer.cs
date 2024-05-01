namespace PseudoBlocks.Vista
{
	partial class frm_AboutBox
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AboutBox));
			tableLayoutPanel = new TableLayoutPanel();
			logoPictureBox = new PictureBox();
			labelProductName = new Label();
			labelVersion = new Label();
			labelCopyright = new Label();
			textBoxDescription = new TextBox();
			okButton = new Button();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.7843132F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.2156868F));
			tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
			tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
			tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
			tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
			tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
			tableLayoutPanel.Controls.Add(okButton, 1, 5);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(12, 13);
			tableLayoutPanel.Margin = new Padding(4);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 6;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2.580645F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 57.0967751F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6129036F));
			tableLayoutPanel.Size = new Size(510, 310);
			tableLayoutPanel.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			logoPictureBox.Dock = DockStyle.Fill;
			logoPictureBox.Image = Properties.Resources.Adnix_Animation;
			logoPictureBox.Location = new Point(4, 4);
			logoPictureBox.Margin = new Padding(4);
			logoPictureBox.Name = "logoPictureBox";
			tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
			logoPictureBox.Size = new Size(200, 302);
			logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			logoPictureBox.TabIndex = 12;
			logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			labelProductName.Dock = DockStyle.Fill;
			labelProductName.Font = new Font("Lexend Deca Medium", 9F);
			labelProductName.Location = new Point(216, 0);
			labelProductName.Margin = new Padding(8, 0, 4, 0);
			labelProductName.MaximumSize = new Size(0, 25);
			labelProductName.Name = "labelProductName";
			labelProductName.Size = new Size(290, 25);
			labelProductName.TabIndex = 19;
			labelProductName.Text = "Nombre de producto";
			labelProductName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelVersion
			// 
			labelVersion.Dock = DockStyle.Fill;
			labelVersion.Font = new Font("Lexend Deca Medium", 9F);
			labelVersion.Location = new Point(216, 30);
			labelVersion.Margin = new Padding(8, 0, 4, 0);
			labelVersion.MaximumSize = new Size(0, 25);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(290, 25);
			labelVersion.TabIndex = 0;
			labelVersion.Text = "Versión";
			labelVersion.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelCopyright
			// 
			labelCopyright.Dock = DockStyle.Fill;
			labelCopyright.Font = new Font("Lexend Deca Medium", 9F);
			labelCopyright.Location = new Point(216, 60);
			labelCopyright.Margin = new Padding(8, 0, 4, 0);
			labelCopyright.MaximumSize = new Size(0, 25);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(290, 25);
			labelCopyright.TabIndex = 21;
			labelCopyright.Text = "Copyright";
			labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBoxDescription
			// 
			textBoxDescription.Dock = DockStyle.Fill;
			textBoxDescription.Font = new Font("Lexend Deca Medium", 9F);
			textBoxDescription.Location = new Point(216, 101);
			textBoxDescription.Margin = new Padding(8, 4, 4, 4);
			textBoxDescription.Multiline = true;
			textBoxDescription.Name = "textBoxDescription";
			textBoxDescription.ReadOnly = true;
			textBoxDescription.ScrollBars = ScrollBars.Both;
			textBoxDescription.Size = new Size(290, 166);
			textBoxDescription.TabIndex = 23;
			textBoxDescription.TabStop = false;
			textBoxDescription.Text = "Descripción\r\n";
			// 
			// okButton
			// 
			okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			okButton.DialogResult = DialogResult.Cancel;
			okButton.Font = new Font("Lexend Deca Medium", 9F);
			okButton.Location = new Point(386, 276);
			okButton.Margin = new Padding(4);
			okButton.Name = "okButton";
			okButton.Size = new Size(120, 30);
			okButton.TabIndex = 24;
			okButton.Text = "&Aceptar";
			// 
			// frm_AboutBox
			// 
			AcceptButton = okButton;
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(534, 336);
			Controls.Add(tableLayoutPanel);
			Font = new Font("Lexend Deca Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frm_AboutBox";
			Padding = new Padding(12, 13, 12, 13);
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Sobre PseudoBlocks";
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Button okButton;
		private Label labelProductName;
	}
}
