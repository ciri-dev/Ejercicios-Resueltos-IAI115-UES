using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {   /*
         * 6- En un almacén se requiere consolidar la información mensual de la 
         * cantidad de productos en existencia. Se tienen 5 diferentes tipos. 
         * Diseñe un programa que muestre lo siguiente: 
         * Total de productos de todos los tipos en el mes. 
         * Promedio de productos de tipo 2 en existencia. 
         * Total de productos por tipo.
         */
        static void Main(string[] args)
        {
            const int tipos = 5;     // 5 tipos de productos
            const int meses = 12;    // 12 meses del año

            int[,] inventario = new int[tipos, meses];

            LeerDatos(inventario);
            Console.WriteLine("\n--- Total de productos por tipo ---");
            MostrarTotalPorTipo(inventario);

            Console.WriteLine("\n--- Total de productos en el mes 6 (Junio) ---");
            Console.WriteLine("Total: " + TotalPorMes(inventario, 5)); 

            Console.WriteLine("\n--- Promedio de productos del tipo 2 ---");
            Console.WriteLine("Promedio: " + PromedioTipo(inventario, 1)); 

            Console.ReadKey();
        }

        // Método para leer y validar los datos del inventario
        static void LeerDatos(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"\nTipo de producto {i + 1}:");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        Console.Write($"Mes {j + 1} - Cantidad: ");
                        if (!int.TryParse(Console.ReadLine(), out matriz[i, j]) || matriz[i, j] < 0)
                        {
                            Console.WriteLine("Valor inválido. Ingrese un número entero no negativo.");
                        }
                    } while (matriz[i, j] < 0);
                }
            }
        }

        // Método para calcular el total de productos en un mes específico
        static int TotalPorMes(int[,] matriz, int mes)
        {
            int total = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                total += matriz[i, mes];
            }
            return total;
        }

        // Método para calcular el promedio de productos de un tipo específico
        static double PromedioTipo(int[,] matriz, int tipo)
        {
            int suma = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                suma += matriz[tipo, j];
            }
            return (double)suma / matriz.GetLength(1);
        }

        // Método para mostrar el total por tipo de producto
        static void MostrarTotalPorTipo(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int total = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    total += matriz[i, j];
                }
                Console.WriteLine($"Tipo {i + 1}: {total} unidades");
            }
        }
        
    }
}
