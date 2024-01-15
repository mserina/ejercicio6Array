using ejercicio6ArrayObligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ArrayObligatorio.Servicios
{
    /// <summary>
    /// Contiene la cabezera de los metodos del servicio de Operacion
    /// msm - 090124
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Metodo que da de alta a los clientes
        /// msm - 090124
        /// </summary>
        /// <param name="listaClientes">listas de los clientes</param>

        public void darAltaCliente(List<ClienteDto> listaClientes);

        /// <summary>
        /// Metodo que ordena los clientes a partir de la edad (de forma ascendente)
        /// msm - 150124
        /// </summary>
        /// <param name="listaClientes">Listas de los clientes</param>

        public void verificarClientesMinimos(List<ClienteDto> listaClientes);
    }
}
