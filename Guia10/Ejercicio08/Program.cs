using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {   /*
         * Se tiene una matriz cuadrada de 25 filas y columnas. 
         * Se necesita un programa  que genere  dos  vectores  vec1  y vec2 a 
         * partir de la matriz, de la siguiente manera:   
         * Si el elemento de la matriz es un número par, se almacenará en vec1 
         * en caso contrario el elemento formará parte de vec2. El programa debe 
         * de imprimir además la suma de todos los elementos de vec1 y el número 
         * de elementos que forman vec2.
         */
        static void Main(string[] args)
        {
           
            const int dimension = 25;
            int[,] matriz = new int[dimension, dimension];
            List<int> vec1 = new List<int>(); // Pares
            List<int> vec2 = new List<int>(); // Impares

            LeerMatriz(matriz);
            ClasificarElementos(matriz, vec1, vec2);

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Suma de elementos pares (vec1): {SumarVector(vec1)}");
            Console.WriteLine($"Cantidad de elementos impares (vec2): {vec2.Count}");

            Console.ReadKey();
        }

        // Método para leer y validar los datos de la matriz
        static void LeerMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"\nFila {i + 1}:");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                        if (!int.TryParse(Console.ReadLine(), out matriz[i, j]) || matriz[i, j] < 0)
                        {
                            Console.WriteLine("Ingrese un número entero no negativo.");
                        }
                    } while (matriz[i, j] < 0);
                }
            }
        }

        // Método para clasificar elementos en pares e impares
        static void ClasificarElementos(int[,] matriz, List<int> vec1, List<int> vec2)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 == 0)
                        vec1.Add(matriz[i, j]);
                    else
                        vec2.Add(matriz[i, j]);
                }
            }
        }

        // Método para sumar los elementos de un vector
        static int SumarVector(List<int> vector)
        {
            int suma = 0;
            foreach (int num in vector)
            {
                suma += num;
            }
            return suma;
        }   
    }
}
