using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Edificio
    {
        public string tipo;
        public double precio;

        public void vender()
        {
            Console.WriteLine($"{tipo} Vendida por el precio de L{precio}");
        }
    }
}
