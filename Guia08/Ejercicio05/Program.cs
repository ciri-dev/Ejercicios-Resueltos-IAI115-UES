using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {   /*
         * 5- Diseñe un programa que pida un número y determine si es primo. 
         * Debe parar cuando se digite el número: -1.
         */
        static void Main(string[] args)
        {
            int numero;

            do
            {
                numero = LeerNumero();

                if (numero != -1)
                {
                    if (EsPrimo(numero))
                        Console.WriteLine($"{numero} es un número primo.");
                    else
                        Console.WriteLine($"{numero} NO es un número primo.");
                }

            } while (numero != -1);

            Console.WriteLine("Programa finalizado.");
        }

        // Método para leer un número entero
        static int LeerNumero()
        {
            Console.Write("Ingrese un número (-1 para salir): ");
            return int.Parse(Console.ReadLine());
        }

        // Método para verificar si un número es primo
        static bool EsPrimo(int n)
        {
            if (n <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
