using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Casa : Inmueble
    {
        public Casa() { }
        public Casa(string tipo, double precio) {
            this.tipoInmueble = tipo;
            this.precio = precio;
        }

        public Casa(string tipo, double precio, double areaTerreno, string ubicacion)
        {
            this.tipoInmueble = tipo;
            this.precio = precio;
            this.areaTerreno = areaTerreno;
            this.ubicacion = ubicacion;
        }
    }
}
