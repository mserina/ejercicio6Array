using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ArrayObligatorio.Servicios
{
    /// <summary>
    /// Interfaz, contiene la cabecera de los metodos del menu
    /// msm -090124
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y la respuesta del usuario
        ///  msm -090124
        /// </summary>
        /// <returns>La respuesta del usuario</returns>
        public int mostrarMenuYRespuesta();

    }
}
