using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {   /*
         * 18- Desplegar por pantalla los primeros 15 números positivos múltiplos de 3
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Primeros 15 múltiplos positivos de 3:");

            for (int i = 1; i <= 15; i++)
            {
                int multiplo = i * 3;
                Console.WriteLine(multiplo);
            }
        }
    }
}
