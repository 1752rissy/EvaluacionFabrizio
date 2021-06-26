using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Materia:IABM
    {
       public String NomMateria { get; set; }

        public string Alta()
        {
            return "Dando alta Materia...";
        }

        public string Baja()
        {
            return "Dando de baja Materia";
        }

        public string Modificar()
        {
            return "Modificando Materia...";
        }
    }
}
