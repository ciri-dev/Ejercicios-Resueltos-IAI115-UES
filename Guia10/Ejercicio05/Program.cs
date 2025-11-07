using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {   /*
         * 5- En una universidad se conoce el número de alumnos que ingresaron en sus 7 diferentes 
         * carreras, en los últimos 12 años. Diseñe un programa que pueda proporcionar la siguiente 
         * información: 
         * Total de alumnos por año 
         * Porcentaje de alumnos ingresados en el año X de la carrera Y 
         * En qué año y en qué carrera se dio el menor ingreso de alumnos 
         * Año en el cual la carrera T tuvo mayor ingreso de alumnos.
         */
        static void Main(string[] args)
        {
            const int carreras = 7;
            const int años = 12;
            int[,] ingresos = new int[carreras, años];

            LeerIngresos(ingresos);
            MostrarTotalesPorAño(ingresos);

            Console.Write("\nIngrese año (1-12) y carrera (1-7) para calcular porcentaje: ");
            int año = LeerIndice("Año", años);
            int carrera = LeerIndice("Carrera", carreras);
            CalcularPorcentaje(ingresos, año, carrera);

            EncontrarMenorIngreso(ingresos);
            Console.Write("\nIngrese carrera (1-7) para buscar su año de mayor ingreso: ");
            int carreraT = LeerIndice("Carrera", carreras);
            EncontrarMayorIngresoPorCarrera(ingresos, carreraT);

            Console.ReadKey();
        }

        static int LeerIndice(string etiqueta, int limite)
        {
            int valor;
            do
            {
                Console.Write($"{etiqueta}: ");
            } while (!int.TryParse(Console.ReadLine(), out valor) || valor < 0 || valor >= limite);
            return valor;
        }

        static void LeerIngresos(int[,] matriz)
        {
            Console.WriteLine("Ingrese los datos de ingreso por carrera y año:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int valor;
                    do
                    {
                        Console.Write($"Carrera {i + 1}, Año {j + 1}: ");
                    } while (!int.TryParse(Console.ReadLine(), out valor) || valor < 0);
                    matriz[i, j] = valor;
                }
            }
        }

        static void MostrarTotalesPorAño(int[,] matriz)
        {
            Console.WriteLine("\nTotal de alumnos por año:");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int total = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    total += matriz[i, j];
                }
                Console.WriteLine($"Año {j}: {total} alumnos");
            }
        }

        static void CalcularPorcentaje(int[,] matriz, int año, int carrera)
        {
            int totalAño = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                totalAño += matriz[i, año];
            }

            if (totalAño == 0)
            {
                Console.WriteLine("No hubo ingresos ese año.");
                return;
            }

            double porcentaje = (double)matriz[carrera, año] / totalAño * 100;
            Console.WriteLine($"Porcentaje de alumnos en carrera {carrera} en año {año}: {porcentaje:F2}%");
        }

        static void EncontrarMenorIngreso(int[,] matriz)
        {
            int menor = matriz[0, 0];
            int carreraMin = 0, añoMin = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                        carreraMin = i;
                        añoMin = j;
                    }
                }
            }

            Console.WriteLine($"\nMenor ingreso: {menor} alumnos en carrera {carreraMin}, año {añoMin}");
        }

        static void EncontrarMayorIngresoPorCarrera(int[,] matriz, int carrera)
        {
            int mayor = matriz[carrera, 0];
            int añoMayor = 0;

            for (int j = 1; j < matriz.GetLength(1); j++)
            {
                if (matriz[carrera, j] > mayor)
                {
                    mayor = matriz[carrera, j];
                    añoMayor = j;
                }
            }

            Console.WriteLine($"Mayor ingreso en carrera {carrera}: {mayor} alumnos en año {añoMayor}");
        }
        
    }
}
