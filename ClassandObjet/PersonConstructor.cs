using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObjet
{
    internal class PersonConstructor
    {

        public string Nombre { get; set; }
        public int Edad { get; set;}

        public string Estado { get; set; }

        // Constructor por defecto
        public PersonConstructor()
        {
            // Inicialización básica
            Nombre = "Sin nombre";
            Edad = 0;
            Estado = "Inactivo";
        }

        // Constructor con parámetros
        public PersonConstructor(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            Estado = "Activo";
        }

    }
}
