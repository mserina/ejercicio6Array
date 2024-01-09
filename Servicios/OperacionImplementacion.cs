using ejercicio6ArrayObligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ArrayObligatorio.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {

        
        public void darAltaCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto clienteNuevo = crearCliente();
            listaClientes.Add(clienteNuevo);

        }


        
        private ClienteDto crearCliente()
        {
            long id;
            string nombre;
            string apellidos;
            int edad;

            Console.WriteLine("Inserte ID");
            id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Inserte Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Inserte Apellido");
            apellidos = Console.ReadLine();
            Console.WriteLine("Inserte Edad");
            edad = Convert.ToInt32(Console.ReadLine());

            ClienteDto clienteNuevo = new ClienteDto(id, nombre, apellidos, edad);

            return clienteNuevo;
        }


        public void verificarClientesMinimos(List<ClienteDto> listaClientes)
        {
            if (listaClientes.Count >= 3)
            {
                Console.WriteLine("LISTA DESORDENADA");
                foreach (var item in listaClientes)
                {
                    Console.WriteLine(item.ToString());
                }



            }
            else
            {
                Console.WriteLine("Debe haber minimo 3 clientes registrados");
            }
        }
    }
}
