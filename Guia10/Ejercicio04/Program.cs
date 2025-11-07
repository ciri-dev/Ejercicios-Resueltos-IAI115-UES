using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {   /*
         * 4- Dada una matriz cuadrada nxn, cuyos elementos enteros deben 
         * estar entre 10 y 60, diseñar un programa que determine si dicha 
         * matriz el simétrica. Se considera que una matriz es simétrica, 
         * si a[i][j] == a[j][i]
         */
        static void Main(string[] args)
        {
            int n = LeerEnteroPositivo("Ingrese el tamaño de la matriz cuadrada (n): ");
            int[,] matriz = new int[n, n];

            LeerMatrizValidada(matriz);
            MostrarMatriz(matriz);

            bool esSimetrica = EsSimetrica(matriz);

            Console.WriteLine($"\n¿La matriz es simétrica? {(esSimetrica ? "Sí" : "No")}");
            Console.ReadKey();
        }

        /// <summary>
        /// Solicita un entero positivo con validación.
        /// </summary>
        static int LeerEnteroPositivo(string mensaje)
        {
            int valor;
            do
            {
                Console.Write(mensaje);
            } while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0);
            return valor;
        }

        /// <summary>
        /// Lee los elementos de la matriz y valida que estén entre 10 y 60.
        /// </summary>
        static void LeerMatrizValidada(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int valor;
                    do
                    {
                        Console.Write($"Elemento [{i},{j}] (entre 10 y 60): ");
                    } while (!int.TryParse(Console.ReadLine(), out valor) || valor < 10 || valor > 60);

                    matriz[i, j] = valor;
                }
            }
        }

        /// <summary>
        /// Verifica si la matriz es simétrica respecto a su diagonal principal.
        /// </summary>
        static bool EsSimetrica(int[,] matriz)
        {
            int n = matriz.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++) 
                {
                    if (matriz[i, j] != matriz[j, i])
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Muestra la matriz en consola.
        /// </summary>
        static void MostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("\nMatriz ingresada:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        
    }
}
