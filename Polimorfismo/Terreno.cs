using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Terreno : Inmueble
    {
        public Terreno(string tipoInmueble, double precio) {
            this.tipoInmueble = tipoInmueble;
            this.precio = precio;
        }
    }
}
