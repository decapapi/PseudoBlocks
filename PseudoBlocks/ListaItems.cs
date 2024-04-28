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
		private readonly bool libre;

		public ListaItems() : this (new Point(5, 5)) { }

		public ListaItems(bool libre) : this(new Point(5, 5), libre) { }

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
			item.Location = libre ? margin : this.UltimaPosicion();
			item.BringToFront();
			this.Items.Add(item);
			OrdenarControles();
		}

		public void Eliminar(Control item)
		{
			item.Dispose();
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

		public Control Anterior(Control control)
		{
			if (this.Items.IndexOf(control) > 0)
				return this.Items[this.Items.IndexOf(control) - 1];
			else
				return control;
		}

		public void OrdenarControles(object? sender, EventArgs e)
		{
			if (!libre && this.Items.Count > 0)
			{
				// Ordenar controles por posición Y
				this.Items.Sort(delegate (Control c1, Control c2) {
					return c1.Location.Y.CompareTo(c2.Location.Y);
				});

				Point localizacion = margin;
				for (int i = 0; i < this.Items.Count; i++)
				{
					this.Items[i].Location = localizacion;
					localizacion.Y += this.Items[i].Height;
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
				Point pos = c.Location;
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
				Point pos = c.Location;
				if (pos.Y < 0)
					pos.Y = 0;
				if (pos.X < 0)
					pos.X = 0;
				return pos;
			}
		}

		public bool Contiene(Control control)
		{
			return this.Items.Contains(control);
		}

		public void Limpiar()
		{
			this.Items.Clear();
		}

		~ListaItems()
		{
			this.Items.ForEach(control => control.Dispose());
			this.Items.Clear();
		}
	}
}
