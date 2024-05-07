namespace PseudoPlayer
{
	partial class frm_Player
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Player));
			SuspendLayout();
			// 
			// frm_Player
			// 
			AutoScaleDimensions = new SizeF(10F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 461);
			DoubleBuffered = true;
			Font = new Font("Lexend Deca Medium", 9F);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			Name = "frm_Player";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PseudoPlayer";
			ResumeLayout(false);
		}

		#endregion
	}
}