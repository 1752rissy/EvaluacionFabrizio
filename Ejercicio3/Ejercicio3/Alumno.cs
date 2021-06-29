using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Alumno:IABM,IBusqueda
    {
       //donde estan los metodos  para BUSCAR ALUMNOS POR MATERIA  Y ALUMMOS POR CARRERA??????????
        private Materia mat;//si lo pones por defecto es publico y debe ser private. 
        public String nombre { get; set; }
        public String apellido { get; set; }

        public String dni { get; set; }

        Carrera carrera = new Carrera();

        public Alumno(Materia materia) //si lo agregas en el constructor es una COMPOSICION y se especifica una AGREGACION en el modelo.
            //Para que sea una AGREGACION se puede agregar en un metodo a parte. 
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
