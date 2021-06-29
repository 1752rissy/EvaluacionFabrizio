using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    //Nunca nombrar una interfaz todo en MAYUSCULA. Tener en cuenta para el final 
    public interface IABM
    {
        //nombrar siempre los metodos como acciones. Insertar, Eliminar, Modificar.
        String Alta();
        String Baja();
        String Modificar();

    }
}
