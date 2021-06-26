using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class OperacionesBusqueda
    {
        private readonly IBusqueda _operacionesBusqueda;

        public OperacionesBusqueda(IBusqueda operacionesBusqueda)
        {
            _operacionesBusqueda = operacionesBusqueda;
        }

        public String BuscarXDni()
        {
            return _operacionesBusqueda.BuscarXDni();
        }
    }
}
