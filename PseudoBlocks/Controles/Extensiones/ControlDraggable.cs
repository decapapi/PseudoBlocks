using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PseudoBlocks.Controles.Extensiones
{
	public static class ControlDraggable
	{
		private static Dictionary<Control, bool> draggables = new Dictionary<Control, bool>();
		private static Size mouseOffset;

		public static void Draggable(this Control control, bool enable)
		{
			if (enable)
			{
				if (draggables.ContainsKey(control))
					return;

				draggables.Add(control, false);
				control.MouseDown += Control_MouseDown;
				control.MouseUp += Control_MouseUp;
				control.MouseMove += Control_MouseMove;
			}
			else
			{
				if (!draggables.ContainsKey(control))
					return;

				control.MouseDown -= Control_MouseDown;
				control.MouseUp -= Control_MouseUp;
				control.MouseMove -= Control_MouseMove;

				draggables.Remove(control);
			}
		}

		private static void Control_MouseDown(object sender, MouseEventArgs e)
		{
			mouseOffset = new Size(e.Location);
			draggables[(Control)sender] = true;
			((Control)sender).BringToFront();
		}

		private static void Control_MouseUp(object sender, MouseEventArgs e)
		{
			Control control = (Control)sender;
			draggables[control] = false;
			if (control is Bloque bloque)
				bloque.DoDragDrop(bloque, DragDropEffects.Copy);
		}

		private static void Control_MouseMove(object sender, MouseEventArgs e)
		{
			if (draggables[(Control)sender] == true)
			{
				Point newLocationOffset = e.Location - mouseOffset;
				((Control)sender).Left += newLocationOffset.X;
				((Control)sender).Top += newLocationOffset.Y;
			}
		}
	}
}
