using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {   /*
         * 3- Se tiene un vector de 50 elementos se necesita saber si todos son 
         * positivos o negativos. Para ello se le pide que diseñe un programa que 
         * imprima “CIERTO”  si todos son positivos,  “FALSO” si todos son negativos
         * y, “MIXTO” si el vector tiene elementos positivos y negativos.
         */
        static void Main(string[] args)
        {
            int[] numeros = new int[50];

            Console.WriteLine("=== Clasificación de elementos en un vector de 50 números ===");
            LeerVector(numeros);

            string resultado = ClasificarVector(numeros);

            Console.WriteLine($"\nResultado: {resultado}");
        }

        // Método para leer 50 números enteros (positivos o negativos)
        static void LeerVector(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Ingrese el número #{i + 1} (positivo o negativo): ");
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

        // Método para clasificar el vector como CIERTO, FALSO o MIXTO
        static string ClasificarVector(int[] arreglo)
        {
            bool hayPositivos = false;
            bool hayNegativos = false;

            foreach (int numero in arreglo)
            {
                if (numero > 0) hayPositivos = true;
                if (numero < 0) hayNegativos = true;

                if (hayPositivos && hayNegativos)
                    return "MIXTO";
            }

            if (hayPositivos && !hayNegativos)
                return "CIERTO";
            else if (!hayPositivos && hayNegativos)
                return "FALSO";
            else
                return "Todos los elementos son cero";
        }
        
    }
}
