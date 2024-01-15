
using ejercicio6ArrayObligatorio.Dtos;
using ejercicio6ArrayObligatorio.Servicios;

namespace ejercicio6ArrayObligatorio
{
    /// <summary>
    /// Clase principal
    /// msm - 090124
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo main, contiene el procediento del programa.
        /// msm - 090124
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {
            //Listas

            List<ClienteDto> listaClientes = new List<ClienteDto>();

            //Variables
            bool cerrarMenu = false;
            int respuestaUsuario;

            //Objetos 
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            
            while (!cerrarMenu)
            {
                respuestaUsuario = mi.mostrarMenuYRespuesta();

                switch (respuestaUsuario)
                {
                    case 0:
                        Console.WriteLine("HASTA LA PROXIMA");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("HA SELECCIONADO LA OPCION 1");
                        op.darAltaCliente(listaClientes);
                        
                        break;
                    case 2:
                        op.verificarClientesMinimos(listaClientes);
                        foreach (var item in listaClientes)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                }
            }
        }
    }
}