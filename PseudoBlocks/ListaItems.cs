﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks
{
	class ListaItems
	{
		private List<Control> Items = new List<Control>();

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
			this.Items.Add(item);
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

		public void OrdenarControles(object? sender, EventArgs e)
		{
			if (this.Items.Count > 0)
			{
				this.Items.Sort(delegate (Control c1, Control c2) {
					return c1.Location.Y.CompareTo(c2.Location.Y);
				});

				Point localizacion = this.PrimeraPosicion();
				if (localizacion.Y < 10)
					localizacion.Y = 10;
				if (localizacion.X < 10)
					localizacion.X = 10;

				foreach (Control item in this.Items)
				{
					item.Location = localizacion;
					localizacion.Y += 40;
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
				return new Point(10, 10);
			}
			else
			{
				Control c = this.Items.First();
				return new Point(c.Location.X, c.Location.Y);
			}
		}

		public Point UltimaPosicion()
		{
			if (this.Items.Count == 0)
			{
				return new Point(10, 10);
			}
			else
			{
				Control c = this.Items.Last();
				return new Point(c.Location.X, c.Location.Y);
			}
		}

		public void Limpiar()
		{
			this.Items.Clear();
		}
	}
}
