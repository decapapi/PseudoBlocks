using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
using PseudoBlocks.Controles;
using PseudoBlocks.Controles.Archivos;
using PseudoBlocks.Controles.Numerico;
using PseudoBlocks.Controles.Logica;
using PseudoBlocks.Controles.Eventos;

namespace PseudoBlocks
{
	public partial class frm_Editor : Form
	{
		private readonly ListaItems listaItems = new ListaItems(new Point(10, 10));

		public frm_Editor()
		{
			InitializeComponent();
		}

		public void AgregarComponente(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				string controlType = control.Name.Substring(control.Name.IndexOf('_') + 1);
				string[] controlInfo = controlType.Split('_');
				switch (controlInfo[0])
				{
					case "move": // Movimiento
						AgregarControl(new Bloque(controlType, control.Text, Color.MediumAquamarine));
						break;
					case "change": // Escenario
						switch (controlInfo[1])
						{
							case "background":
							case "character":
								AgregarControl(new BloqueImagen(controlType, control.Text, Color.LightBlue));
								break;
							case "size":
								AgregarControl(new BloqueXY(controlType, control.Text, Color.LightBlue));
								break;
						}
						break;
					case "sound": // Sonido
						AgregarControl(new BloqueAudio(controlType, control.Text, Color.FromArgb(255, 192, 255)));
						break;
					case "logic": // Lógica
						switch (controlInfo[1])
						{
							case "wait":
								AgregarControl(new BloqueNumerico(controlType, control.Text, Color.LightSalmon));
								break;
							case "repeat":
								AgregarControl(new BloqueRepetir(controlType, control.Text, Color.LightSalmon));
								break;
							case "repeatAlways":
								AgregarControl(new BloquePanel(controlType, control.Text, Color.LightSalmon));
								break;
						}
						break;
					case "event": // Eventos
						switch (controlInfo[1])
						{
							case "onload":
							case "onclick":
								AgregarControl(new BloquePanel(controlType, control.Text, Color.LightCoral));
								break;
							case "onpress":
								AgregarControl(new BloqueHotkey(controlType, control.Text, Color.LightCoral));
								break;
						}
						break;
				}
			}
		}

		private void AgregarControl(Bloque control)
		{
			listaItems.Agregar(control);
			pnl_layout_principal.Controls.Add(control);
			control.ContextMenuStrip.ItemClicked += (sender, e) => EliminarControl(control);
			control.BringToFront();
		}

		private void EliminarControl(Bloque control)
		{
			pnl_layout_principal.Controls.Remove(control);
			listaItems.Eliminar(control);
		}

		private void CambiarCategoria(object sender, EventArgs e)
		{
			if (sender is Button btn)
			{
				switch (btn.Name.Substring(btn.Name.IndexOf('_') + 1))
				{
					case "movimiento":
						pnl_components.ScrollControlIntoView(pnl_movimiento);
						break;
					case "escenario":
						pnl_components.ScrollControlIntoView(pnl_escenario);
						break;
					case "sonido":
						pnl_components.ScrollControlIntoView(pnl_sonido);
						break;
					case "logica":
						pnl_components.ScrollControlIntoView(pnl_logica);
						break;
					case "eventos":
						pnl_components.ScrollControlIntoView(pnl_eventos);
						break;
				}
			}
		}
	}
}
