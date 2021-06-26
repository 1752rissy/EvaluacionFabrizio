using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Alumno
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

    }
}
