using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObjet
{
    internal class EdadValidate
    {

        public bool validateAge(int edad)//Parametro
        {
            if (edad>=18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}
