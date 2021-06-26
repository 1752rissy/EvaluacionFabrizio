using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Carrera:IABM
    {
        public string nomCarrera { get; set; }

        public string Alta()
        {
            return "Dando alta Carrera...";
        }

        public string Baja()
        {
            return "Dando de baja Carrera...";
        }

        public string Modificar()
        {
            return "Modificando Carrera...";
        }
    }
}
