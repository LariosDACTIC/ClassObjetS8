using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObjet
{
    internal class Person
    {


        // Campos (variables)
        public string Nombre; //Variables de Instancia
        public int Edad;//Variables de Instancia


        public static int cantidad; // Variable estática

        public readonly double PI = 3.14159; // Variable de solo lectura





        // Método (función)
        public void Saludar()
        {
            Console.WriteLine($"¡Hola! Mi nombre es {Nombre} y tengo {Edad} años.");
        }

    }
}
