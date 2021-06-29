using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Y LAS OPERACIONES PARA BUSCAR ALUMNOS POR MATERIA Y POR CARRERA ????????????????

            Carrera carrera = new Carrera();
            Materia materia = new Materia();
            Alumno alumno = new Alumno(materia);
            Profesor profesor = new Profesor();
            OperacionesABM operacionesabm = new OperacionesABM(alumno);
            OperacionesABM operacionesabm2 = new OperacionesABM(profesor);
            OperacionesABM operacionesabm3 = new OperacionesABM(materia);
            OperacionesABM operacionesabm4 = new OperacionesABM(carrera);
            OperacionesBusqueda operacionbusq = new OperacionesBusqueda(alumno);
            OperacionesBusqueda operacionbusq2 = new OperacionesBusqueda(profesor);
            Console.WriteLine(operacionbusq.BuscarXDni());
            Console.WriteLine(operacionbusq2.BuscarXDni());
            Console.WriteLine(operacionesabm.Alta());
            Console.WriteLine(operacionesabm2.Baja());
            Console.WriteLine(operacionesabm3.Modificar());
            Console.WriteLine(operacionesabm4.Alta());
            Console.ReadLine();
            


        }
    }
}
