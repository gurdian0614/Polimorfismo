using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Inmueble
    {
        public string tipoInmueble {  get; set; }
        public string ubicacion {  get; set; }
        public double areaTerreno { get; set; }
        public double precio { get; set; }

        public void vender()
        {
            //Console.WriteLine(tipoInmueble + " Vendida por el precio de L" + precio);
            Console.WriteLine($"{tipoInmueble} Vendida por el precio de L{precio}");
        }

        public void vender(string cliente)
        {
            Console.WriteLine($"{tipoInmueble} Vendida por el precio de L{precio} por cliente: {cliente}");
        }

        public void vender(double descuento)
        {
            Console.WriteLine($"{tipoInmueble} Vendida por el precio de L{precio} con descuento L{descuento}");
        }

        public void vender(string cliente, double descuento)
        {
            Console.WriteLine($"{tipoInmueble} Vendida por el precio de L{precio} por cliente: {cliente} con un descuento de L{descuento}");
        }
    }
}
