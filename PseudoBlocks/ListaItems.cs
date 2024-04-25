using PseudoBlocks.Controles.Extensiones;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoBlocks
{
	class ListaItems
	{
		public List<Control> Items { get; private set; } = new List<Control>();
		private Point margin;
		private bool libre;

		public ListaItems() : this (new Point(10, 0)) { }

		public ListaItems(bool libre) : this(new Point(10, 0), libre) { }

		public ListaItems(Point marging, bool libre = true)
		{
			this.margin = marging;
			this.libre = libre;
		}

		public void Mover(Control item, int movimiento)
		{
			if (this.Items.IndexOf(item) != -1)
			{
				int oldIndex = this.Items.IndexOf(item);
				int newIndex = oldIndex + movimiento;
				if (newIndex > -1 && newIndex < this.Items.Count)
				{
					this.Items.RemoveAt(oldIndex);
					this.Items.Insert(newIndex, item);
				}
			}
		}

		public void Agregar(Control item)
		{
			item.Location = this.UltimaPosicion();
			item.Draggable(true);
			item.BringToFront();
			this.Items.Add(item);
			OrdenarControles();
		}

		public void Eliminar(Control item)
		{
			this.Items.Remove(item);
			this.OrdenarControles();
		}

		public void Eliminar(int index)
		{
			this.Items.RemoveAt(index);
		}

		public void Subir(Control item)
		{
			this.Mover(item, -1);
		}

		public void Bajar(Control item)
		{
			this.Mover(item, 1);
		}

		public bool Existe(Control c)
		{
			return this.Items.Contains(c);
		}

		public Control Primero()
		{
			if (this.Items.Count > 0)
			{
				return this.Items.First();
			}
			else
			{
				return null;
			}
		}

		public Control Ultimo()
		{
			if (this.Items.Count > 0)
			{
				return this.Items.Last();
			}
			else
			{
				return null;
			}
		}

		public void OrdenarControles(object? sender, EventArgs e)
		{
			if (this.Items.Count > 0)
			{
				this.Items.Sort(delegate (Control c1, Control c2) {
					return c1.Location.Y.CompareTo(c2.Location.Y);
				});

				int localizacionY = libre ? this.PrimeraPosicion().Y : margin.Y;

				for (int i = 0; i < this.Items.Count; i++)
				{
					this.Items[i].Location = new Point(margin.X, localizacionY);
					localizacionY += 40;
				}
			}
		}

		public void OrdenarControles()
		{
			this.OrdenarControles(null, null);
		}

		public Point PrimeraPosicion()
		{
			if (this.Items.Count == 0)
			{
				return new Point(0, 0);
			}
			else
			{
				Control c = Primero();
				Point pos = new Point(c.Location.X, c.Location.Y);
				if (pos.Y < 0)
					pos.Y = 0;
				if (pos.X < 0)
					pos.X = 0;
				return pos;
			}
		}

		public Point UltimaPosicion()
		{
			if (this.Items.Count == 0)
			{
				return new Point(0, 0);
			}
			else
			{
				Control c = Ultimo();
				Point pos = new Point(c.Location.X, c.Location.Y);
				if (pos.Y < 0)
					pos.Y = 0;
				if (pos.X < 0)
					pos.X = 0;
				return pos;
			}
		}

		public void Limpiar()
		{
			this.Items.Clear();
		}
	}
}
