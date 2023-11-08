using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Departamento : Inmueble
    {
        public Departamento(string tipoInmueble, double prec) {
            this.tipoInmueble = tipoInmueble;
            this.precio = prec;
        }
    }
}
