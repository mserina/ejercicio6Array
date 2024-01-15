using ejercicio6ArrayObligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ArrayObligatorio.Servicios
{
    /// <summary>
    /// Metodo que desarrolla la logica de los metodos del operacion
    /// msm - 150124
    /// </summary>
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

                Console.WriteLine(" ");
                Console.WriteLine("LISTA ORDENADO");
                for (int i = 0; i < listaClientes.Count -1; i++)
                {
                    for (int j = 0; j < listaClientes.Count -1 -i; j++)
                    {
                        //OJO: hay que poner el campo que queremos comparar
                        if (listaClientes[j].Edad > listaClientes[j + 1].Edad)
                        {
                            int aux = listaClientes[j].Edad;
                            listaClientes[j].Edad = listaClientes[j + 1].Edad;
                            listaClientes[j + 1].Edad = aux;
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Debe haber minimo 3 clientes registrados");
            }
        }
    }
}
