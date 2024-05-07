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


			codigo.Insert(indiceInicio + 1, "			// Inicio de código generado por PseudoBlocks");

			foreach (DatosBloque bloque in bloques)
			{
				codigo.Insert(indiceInicio + 2, "			" + ObtenerCodigo(bloque));
			}

			codigo.Insert(indiceInicio + 3, "			// Fin de código generado por PseudoBlocks");

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
				case "logic_repeatAlways":
					codigo = "while(true) {";
					foreach (DatosBloque bloque in ((DatosBloquePanel)datosBloque).Bloques)
					{
						codigo += ObtenerCodigo(bloque);
					}
					codigo += "}";
					break;
				case "logic_repeat":
					codigo = "for(int i = 0; i < " + ((DatosBloqueRepetir)datosBloque).Repeticiones + "; i++) {";
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
			}
			return codigo;
		}
	}
}
