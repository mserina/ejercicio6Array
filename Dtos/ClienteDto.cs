using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6ArrayObligatorio.Dtos
{
    /// <summary>
    /// Clase donde se almacena los metodos de atributos de un cliemte
    /// msm - 090124
    /// </summary>
    internal class ClienteDto
    {
        //Atributos (CARACTERISTICAS)

        long idCliente;
        string nombreCliente;
        string apellidosCliente;
        string nombreCompletoCliente;
        int edad;


        //GETERS Y SETTERS

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }


        //CONSTRUCTORES

        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCliente + apellidosCliente;
            this.edad = edad;
        }

        public ClienteDto()
        {

        }

        //TO STRING 
        override
        public string ToString()
        {
            string clienteString =
            "NombreCompleto: " + this.nombreCompletoCliente +
            " Edad: " + this.edad;
            
            return clienteString;
            
        }
    }
}
