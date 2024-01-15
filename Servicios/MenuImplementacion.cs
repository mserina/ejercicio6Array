using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ArrayObligatorio.Servicios
{
    /// <summary>
    /// Metodo que desarrolla la logica de los metodos del menu
    /// msm - 150124
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYRespuesta()
        {

            int opcionSeleccionada;

            Console.WriteLine("");
            Console.WriteLine("######--MENU--######");
            Console.WriteLine("0º CERRAR MENU");
            Console.WriteLine("1º DAR ALTA");
            Console.WriteLine("2º ORDENAR CLIENTES");
            Console.WriteLine("####################");
            Console.WriteLine("");

            opcionSeleccionada = Console.ReadKey(true).KeyChar-('0');
            return opcionSeleccionada;
        }

    }
}
