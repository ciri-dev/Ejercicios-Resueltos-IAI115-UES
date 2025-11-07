using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {   /*
         * 2- Diseñe un programa que llene de ceros una matriz cuadrada de nxn, 
         * excepto la diagonal principal donde debe asignar 1.
         */
        static void Main(string[] args)
        {

            Console.Write("Ingrese el tamaño n de la matriz cuadrada (n > 0): ");
            int n = LeerTamaño();

            int[,] matriz = new int[n, n];

            LlenarDiagonalPrincipal(matriz);
            MostrarMatriz(matriz);

            Console.ReadKey();
        }

        // Valida que el tamaño ingresado sea un entero positivo
        static int LeerTamaño()
        {
            int valor;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                {
                    Console.WriteLine("Ingrese un número entero positivo.");
                }
            } while (valor <= 0);
            return valor;
        }

        // Llena la matriz con ceros excepto la diagonal principal, que se asigna con 1
        static void LlenarDiagonalPrincipal(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = (i == j) ? 1 : 0;
                }
            }
        }

        // Muestra la matriz en consola con formato tabular
        static void MostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("\nMatriz resultante:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
