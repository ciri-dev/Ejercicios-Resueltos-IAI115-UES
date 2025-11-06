using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    internal class Program
    {
        /*
         * 30- Desplegar por pantalla el producto de los primeros 10 números enteros negativos
         */
        static void Main(string[] args)
        {
            int producto = 1;

            for (int i = -1; i >= -10; i--)
            {
                producto *= i;
            }

            Console.WriteLine($"El producto de los primeros 10 números enteros negativos es: {producto}");

        }
    }
}
