using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Profesor:IABM,IBusqueda
    {
        public String nombre { get; set; }
        public String apellido { get; set; }

        public String dni { get; set; }

        Materia materia = new Materia();

        public string Alta()
        {
            return "Dando de alta Profesor";
        }

        public string Baja()
        {
            return "Dando de baja profesor";
        }

        public string Modificar()
        {
            return "Modificando Profesor...";
        }

        public string BuscarXDni()
        {
            return "Buscando profesor x dni...";
        }
    }
}
