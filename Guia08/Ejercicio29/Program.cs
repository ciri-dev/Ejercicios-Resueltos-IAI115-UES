using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    internal class Program
    {   /*
         * 29- Desplegar por pantalla las tablas de multiplicar del 1 al 9
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Tablas de multiplicar del 1 al 9:\n");

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"TABLA DEL {i}");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine(); 
            }
        }
    }
}
