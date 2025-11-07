using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {   /*
         * 6- Diseñe un programa que almacene en un vector los 50 primeros números 
         * primos. Se debe imprimir todo el vector generado
         */
        static void Main(string[] args)
        {
            int[] primos = new int[50];

            Console.WriteLine("=== Generación de los primeros 50 números primos ===");
            GenerarPrimos(primos);
            ImprimirVector("Números primos", primos);
        }

        // Método para generar los primeros 50 números primos
        static void GenerarPrimos(int[] arreglo)
        {
            int contador = 0;
            int numero = 2;

            while (contador < arreglo.Length)
            {
                if (EsPrimo(numero))
                {
                    arreglo[contador] = numero;
                    contador++;
                }
                numero++;
            }
        }

        // Método para verificar si un número es primo
        static bool EsPrimo(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Método para imprimir el contenido del vector
        static void ImprimirVector(string titulo, int[] arreglo)
        {
            Console.WriteLine($"\n{titulo}:");
            foreach (int elemento in arreglo)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
        }
        
    }
}
