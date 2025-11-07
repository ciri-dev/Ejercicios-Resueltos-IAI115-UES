using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {   /*
         * 3- Dada una matriz de nxm elementos, diseñe un programa que 
         * permita calcular cuántos elementos son múltiplos de 5.
         */
        static void Main(string[] args)
        {
            // entrada de datos
            int filas = LeerEnteroPositivo("Ingrese el número de filas: ");
            int columnas = LeerEnteroPositivo("Ingrese el número de columnas: ");

            // Declarar matriz
            int[,] matriz = new int[filas, columnas];

            // Leer datos
            LeerMatriz(matriz);

            // Contar múltiplos de 5
            int cantidadMultiplos = ContarMultiplosDeCinco(matriz);

            // Mostrar resultado
            Console.WriteLine($"\nCantidad de elementos múltiplos de 5: {cantidadMultiplos}");
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
        /// Llena la matriz con valores enteros positivos.
        /// </summary>
        static void LeerMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = LeerEnteroPositivo($"Elemento [{i},{j}]: ");
                }
            }
        }

        /// <summary>
        /// Cuenta cuántos elementos de la matriz son múltiplos de 5.
        /// </summary>
        static int ContarMultiplosDeCinco(int[,] matriz)
        {
            int contador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 5 == 0)
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }
        
    }
}
