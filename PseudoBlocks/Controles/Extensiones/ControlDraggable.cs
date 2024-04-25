using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PseudoBlocks.Controles.Extensiones
{
	public static class ControlDraggable
	{
		private static readonly Dictionary<Control, bool> draggables = new Dictionary<Control, bool>();
		private static readonly Dictionary<Control, Point> mouseOffset = new Dictionary<Control, Point>();

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
			var control = (Control)sender;
			mouseOffset[control] = e.Location;
			draggables[control] = true;
			control.BringToFront();
		}

		private static void Control_MouseUp(object sender, MouseEventArgs e)
		{
			draggables[(Control)sender] = false;
		}

		private static void Control_MouseMove(object sender, MouseEventArgs e)
		{
			var control = (Control)sender;

			if (draggables[control])
			{
				Point newLocation = control.PointToScreen(new Point(e.X, e.Y));
				newLocation.Offset(-mouseOffset[control].X, -mouseOffset[control].Y);
				control.Location = control.Parent.PointToClient(newLocation);
			}
		}
	}
}
