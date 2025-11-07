using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {   /*
         * 5- Diseñe un programa que lea dos vectores de igual magnitud o dimensión 
         * y luego  los compare.  Se debe de imprimir los dos vectores y un mensaje 
         * que indique si son iguales o no. Recordar que: dos vectores son iguales 
         * si cada elemento del primer vector se encuentra exactamente en la misma 
         * posición en el segundo
         */
        static void Main(string[] args)
        { 
            int[] vectorA = new int[10];
            int[] vectorB = new int[10];

            Console.WriteLine("=== Lectura del primer vector ===");
            LeerVector(vectorA);

            Console.WriteLine("\n=== Lectura del segundo vector ===");
            LeerVector(vectorB);

            Console.WriteLine("\n=== Contenido de los vectores ===");
            ImprimirVector("Vector A", vectorA);
            ImprimirVector("Vector B", vectorB);

            bool sonIguales = CompararVectores(vectorA, vectorB);

            Console.WriteLine($"\nResultado de la comparación: {(sonIguales ? "SON IGUALES" : "SON DIFERENTES")}");
        }

        // Método para leer un vector de enteros
        static void LeerVector(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Ingrese el elemento #{i + 1}: ");
                arreglo[i] = LeerEntero();
            }
        }

        // Método para validar y leer un número entero
        static int LeerEntero()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. Ingrese un número entero: ");
            }
            return numero;
        }

        // Método para imprimir el contenido de un vector
        static void ImprimirVector(string nombre, int[] arreglo)
        {
            Console.Write($"{nombre}: ");
            foreach (int elemento in arreglo)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
        }

        // Método para comparar dos vectores elemento por elemento
        static bool CompararVectores(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
    }      
}
