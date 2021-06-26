using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Alumno:IABM,IBusqueda
    {
        Materia mat;
        public String nombre { get; set; }
        public String apellido { get; set; }

        public String dni { get; set; }

        Carrera carrera = new Carrera();

        public Alumno(Materia materia)
        {
            materia = mat;
            
        }

        public string Alta()
        {
            return "Dando alta Alumno...";
        }

        public string Baja()
        {
            return "Dando de baja alumno...";
        }

        public string Modificar()
        {
            return "Modificando Alumno...";
        }

        public string BuscarXDni()
        {
            return "Buscando alumno X dni...";
        }
    }
}
