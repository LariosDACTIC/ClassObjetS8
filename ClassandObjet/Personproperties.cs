using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassandObjet
{
    internal class Personproperties
    {
        private string nombre; // Campo privado para almacenar el valor de la propiedad

        // Propiedad para el nombre
        public string Nombre
        {
            get
            {
                return nombre; // Devuelve el valor del campo
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value; // Establece el valor del campo
                }
                else
                {
                    throw new ArgumentException("El nombre no puede ser nulo ni vacío");
                }
            }
        
        }


        //Nombre es una propiedad que permite leer y escribir el nombre de una persona.
        //El descriptor de acceso get devuelve el valor actual del campo privado _nombre.
        //El descriptor de acceso set valida que el valor asignado no sea nulo o vacío antes de actualizar el campo.

    }
}
