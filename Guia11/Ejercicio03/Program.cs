using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {   /*
         * 3- Invertir los elementos de un vector tipo String.
         */
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese la cantidad de elementos del vector: ");
            int n = LeerTamaño();

            string[] vector = new string[n];
            LeerVector(vector);

            Console.WriteLine("\nVector original:");
            MostrarVector(vector);

            string[] invertido = InvertirVector(vector);

            Console.WriteLine("\nVector invertido:");
            MostrarVector(invertido);

            Console.ReadKey();
        }

        // Valida que el tamaño sea positivo
        static int LeerTamaño()
        {
            int valor;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                    Console.WriteLine("Ingrese un número entero positivo.");
            } while (valor <= 0);
            return valor;
        }

        // Lee los elementos del vector desde consola
        static void LeerVector(string[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vector[i] = Console.ReadLine();
            }
        }

        // Invierte el orden de los elementos del vector
        static string[] InvertirVector(string[] original)
        {
            string[] resultado = new string[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                resultado[i] = original[original.Length - 1 - i];
            }
            return resultado;
        }

        // Muestra los elementos del vector en consola
        static void MostrarVector(string[] vector)
        {
            foreach (string elemento in vector)
            {
                Console.WriteLine($"- {elemento}");
            }
        }
        
    }
}
