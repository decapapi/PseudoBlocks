using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoBlocks.Vista
{
	partial class frm_AboutBox : Form
	{
		public frm_AboutBox()
		{
			InitializeComponent();
			this.labelVersion.Text = String.Format("Versión: {0}", AssemblyVersion);
		}
		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}
	}
}
