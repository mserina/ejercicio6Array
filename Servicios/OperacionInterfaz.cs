using ejercicio6ArrayObligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ArrayObligatorio.Servicios
{
    /// <summary>
    /// Contiene la cabezera de los metodos del servicio de Opperacion
    /// msm - 090124
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Metodo que da de alta a los clientes
        /// msm - 090124
        /// </summary>
        /// <param name="listaClientes"></param>

        public void darAltaCliente(List<ClienteDto> listaClientes);

        public void verificarClientesMinimos(List<ClienteDto> listaClientes);
    }
}
