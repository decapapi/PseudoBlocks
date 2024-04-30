using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PseudoBlocks.Controles;

namespace PseudoBlocks
{
	public class ListaItems
	{
		public List<Bloque> Bloques { get; private set; } = new List<Bloque>();
		private Point margin;
		private readonly bool libre;

		public ListaItems() : this (new Point(5, 5)) { }

		public ListaItems(bool libre) : this(new Point(5, 5), libre) { }

		public ListaItems(Point marging, bool libre = true)
		{
			this.margin = marging;
			this.libre = libre;
		}

		public void Mover(Bloque item, int movimiento)
		{
			if (this.Bloques.IndexOf(item) != -1)
			{
				int oldIndex = this.Bloques.IndexOf(item);
				int newIndex = oldIndex + movimiento;
				if (newIndex > -1 && newIndex < this.Bloques.Count)
				{
					this.Bloques.RemoveAt(oldIndex);
					this.Bloques.Insert(newIndex, item);
				}
			}
		}

		public void Agregar(Bloque item)
		{
			item.Location = libre ? margin : this.UltimaPosicion();
			item.BringToFront();
			this.Bloques.Add(item);
			OrdenarControles();
		}

		public void Eliminar(Bloque item)
		{
			item.Dispose();
			this.Bloques.Remove(item);
			this.OrdenarControles();
		}

		public void Eliminar(int index)
		{
			this.Bloques.RemoveAt(index);
		}

		public void Subir(Bloque item)
		{
			this.Mover(item, -1);
		}

		public void Bajar(Bloque item)
		{
			this.Mover(item, 1);
		}

		public bool Existe(Bloque item)
		{
			return this.Bloques.Contains(item);
		}

		public Control Primero()
		{
			if (this.Bloques.Count > 0)
			{
				return this.Bloques.First();
			}
			else
			{
				return null;
			}
		}

		public Control Ultimo()
		{
			if (this.Bloques.Count > 0)
			{
				return this.Bloques.Last();
			}
			else
			{
				return null;
			}
		}

		public Control Anterior(Bloque control)
		{
			if (this.Bloques.IndexOf(control) > 0)
				return this.Bloques[this.Bloques.IndexOf(control) - 1];
			else
				return control;
		}

		public void OrdenarControles()
		{
			if (!libre && this.Bloques.Count > 0)
			{
				// Ordenar controles por posición Y
				this.Bloques.Sort(delegate (Bloque b1, Bloque b2) {
					return b1.Location.Y.CompareTo(b2.Location.Y);
				});

				Point localizacion = margin;
				for (int i = 0; i < this.Bloques.Count; i++)
				{
					this.Bloques[i].Location = localizacion;
					localizacion.Y += this.Bloques[i].Height;
				}
			}
		}

		public Point PrimeraPosicion()
		{
			if (this.Bloques.Count == 0)
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
			if (this.Bloques.Count == 0)
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
			return this.Bloques.Contains(control);
		}

		public void Limpiar()
		{
			this.Bloques.Clear();
		}

		~ListaItems()
		{
			this.Bloques.ForEach(control => control.Dispose());
			this.Bloques.Clear();
		}
	}
}
