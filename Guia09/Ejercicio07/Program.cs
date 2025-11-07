using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {   /*
         * 7- Se tienen dos vectores a[20] y b[20] diseñe un programa que calcule 
         * e imprima los vectores s[20] y d[20]; sabiendo que: 
         * s[i] =a[i]+b[i] y d[i] = a[i] – b[i]
         */
        static void Main(string[] args)
        {
            int[] a = new int[20];
            int[] b = new int[20];
            int[] s = new int[20];
            int[] d = new int[20];

            Console.WriteLine("=== Lectura del vector A ===");
            LeerVector(a);

            Console.WriteLine("\n=== Lectura del vector B ===");
            LeerVector(b);

            CalcularSumaYResta(a, b, s, d);

            Console.WriteLine("\n=== Resultados ===");
            ImprimirVector("Vector A", a);
            ImprimirVector("Vector B", b);
            ImprimirVector("Vector S (A + B)", s);
            ImprimirVector("Vector D (A - B)", d);
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

        // Método para calcular los vectores de suma y resta
        static void CalcularSumaYResta(int[] a, int[] b, int[] s, int[] d)
        {
            for (int i = 0; i < a.Length; i++)
            {
                s[i] = a[i] + b[i];
                d[i] = a[i] - b[i];
            }
        }

        // Método para imprimir el contenido de un vector
        static void ImprimirVector(string nombre, int[] arreglo)
        {
            Console.WriteLine($"\n{nombre}:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"[{i}] = {arreglo[i]}");
            }
        }
        
    }
}
