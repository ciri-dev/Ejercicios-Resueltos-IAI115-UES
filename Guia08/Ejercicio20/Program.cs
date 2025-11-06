using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    internal class Program
    {   /*
         * 20- Desplegar por pantalla las potencias de 2^0 hasta 2^10
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Potencias de 2 desde 2^0 hasta 2^10:");

            for (int i = 0; i <= 10; i++)
            {
                double resultado = Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {resultado}");
            }
        }
    }
}
