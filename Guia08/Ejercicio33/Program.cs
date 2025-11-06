using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    internal class Program
    {   /*
         * 33- Desplegar por pantalla los valores de X y f(X)= X3+3x+1 para 
         * valores enteros [-5,5]
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Valores de X y f(X) = X^3 + 3X + 1 para X en [-5, 5]:\n");

            for (int x = -5; x <= 5; x++)
            {
                int fx = x * x * x + 3 * x + 1;
                Console.WriteLine($"X = {x}, f(X) = {fx}");
            }
        }
    }
}
