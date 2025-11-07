using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {   /*
         * 2- Diseñe un programa que lea 100 números enteros y positivos. 
         * Después debe leer otro valor (con las mismas características) 
         * y contar e imprimir la cantidad de veces que aparece en el vector.
         */
        static void Main(string[] args)
        {
            int[] numeros = new int[100];

            Console.WriteLine("=== Registro de 100 números enteros y positivos ===");
            LeerNumeros(numeros);

            Console.Write("\nIngrese el número a buscar (entero y positivo): ");
            int valorBuscado = LeerEnteroPositivo();

            int cantidad = ContarOcurrencias(numeros, valorBuscado);

            Console.WriteLine($"\nEl número {valorBuscado} aparece {cantidad} veces en el arreglo.");
        }

        // Método para leer 100 números enteros y positivos
        static void LeerNumeros(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                arreglo[i] = LeerEnteroPositivo();
            }
        }

        // Método para validar y leer un entero positivo
        static int LeerEnteroPositivo()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.Write("Entrada inválida. Ingrese un número entero positivo: ");
            }
            return numero;
        }

        // Método para contar cuántas veces aparece un valor en el arreglo
        static int ContarOcurrencias(int[] arreglo, int valor)
        {
            int contador = 0;
            foreach (int elemento in arreglo)
            {
                if (elemento == valor)
                {
                    contador++;
                }
            }
            return contador;
        }
        
    }
}
