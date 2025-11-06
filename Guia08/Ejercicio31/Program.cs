using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    internal class Program
    {   /*
         * 31- Desplegar por pantalla el cuadrado y el cubo de los números 
         * enteros desde -7 hasta 7.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Cuadrado y cubo de los números enteros desde -7 hasta 7:\n");

            for (int x = -7; x <= 7; x++)
            {
                int cuadrado = x * x;
                int cubo = x * x * x;
                Console.WriteLine($"x = {x} → x² = {cuadrado}, x³ = {cubo}");
            }
        }
    }
}
