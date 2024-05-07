using PseudoBlocks.Controlador;
using PseudoBlocks.Vista.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoBlocks._Datos
{
	class CompiladorBloques
	{
		static int contadorIds = 0;

		public static bool CompilarBloques(List<DatosBloque> bloques)
		{
			string rutaControlador = @".\PseudoPlayer\_Controlador\ControlJuego.cs";

			if (!File.Exists(rutaControlador)) return false;


			List<string> codigo = new List<string>();

			try
			{
				codigo = File.ReadAllLines(rutaControlador).ToList();
			} catch { return false; }


			int indiceInicio = codigo.FindIndex(x => x.Contains("<INICIO>"));
			int indiceActualizar = codigo.FindIndex(x => x.Contains("<ACTUALIZAR>"));
			int indicePulsar = codigo.FindIndex(x => x.Contains("<PULSAR>"));

			foreach (DatosBloque bloque in bloques)
			{
				if (bloque.Tipo == "event_onload")
				{
					codigo.Insert(++indiceInicio, "			" + ObtenerCodigo(bloque));
				}
				if (bloque.Tipo == "logic_repeatAlways")
				{
					codigo.Insert(++indiceInicio, "			" + ObtenerCodigo(bloque));
				}
				else if (bloque.Tipo == "event_onpress")
                {
					codigo.Insert(++indicePulsar, "			" + ObtenerCodigo(bloque));
				}
			}

			try
			{
				File.WriteAllLines(rutaControlador, codigo);
			} catch { return false; }

			return true;
		}

		public static string ObtenerCodigo(DatosBloque datosBloque)
		{
			string codigo = string.Empty;
			switch (datosBloque.Tipo)
			{
				case "move_right":
					codigo = "personaje.MoverDerecha();";
					break;
				case "move_left":
					codigo = "personaje.MoverIzquierda();";
					break;
				case "move_up":
					codigo = "personaje.MoverArriba();";
					break;
				case "move_down":
					codigo = "personaje.MoverAbajo();";
					break;
				case "move_to":
					codigo = "personaje.MoverA(" + ((DatosBloqueXY)datosBloque).X + ", " + ((DatosBloqueXY)datosBloque).Y + ");";
					break;
				case "change_size":
					codigo = "playerWindow.Size = new Size(" + ((DatosBloqueXY)datosBloque).X + ", " + ((DatosBloqueXY)datosBloque).Y + ");";
					break;
				case "logic_wait":
					codigo = "Thread.Sleep(" + ((DatosBloqueNumerico)datosBloque).Valor + ");";
					break;
				case "logic_stopRepeating":
					codigo = "break;";
					break;
				case "logic_repeat":
					contadorIds++;
					codigo = $"for(int i{contadorIds} = 0; i{contadorIds} < {((DatosBloqueRepetir)datosBloque).Repeticiones}; i{contadorIds}++) {{";
					foreach (DatosBloque bloque in ((DatosBloqueRepetir)datosBloque).Bloques)
					{
						codigo += ObtenerCodigo(bloque);
					}
					codigo += "}";
					break;
				case "event_onload":
					foreach (DatosBloque bloque in ((DatosBloquePanel)datosBloque).Bloques)
					{
						codigo = ObtenerCodigo(bloque);
					}
					break;
				case "event_onpress":
					codigo = "case " + ((DatosBloqueHotkey)datosBloque).Tecla.GetHashCode() + ":";
					foreach (DatosBloque bloque in ((DatosBloqueHotkey)datosBloque).Bloques)
					{
						codigo += ObtenerCodigo(bloque);
					}
					codigo += "break;";
					break;
			}
			return codigo;
		}
	}
}
