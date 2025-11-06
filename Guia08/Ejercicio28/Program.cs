using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{
    internal class Program
    {   /*
         * 28- Desplegar por pantalla el factorial desde 0! hasta 7!
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Factoriales desde 0! hasta 7!:");

            for (int n = 0; n <= 7; n++)
            {
                int fact = 1;

                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }

                Console.WriteLine($"{n}! = {fact}");
            }
        }
    }
}
