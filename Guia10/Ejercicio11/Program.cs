using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {   /*
         * 11- En una empresa laboran 25 empleados que obtienen sus ingresos de 
         * acuerdo a las comisiones obtenidas por sus ventas.  Si se tiene el 
         * registro del salario mensual, en los últimos tres meses de cada uno 
         * de los empleados(inicialice la matriz), se solicita elaborar un programa que calcule: 
         * Salario promedio de todos los empleados 
         * Total a pagar por la empresa en la planilla de cada mes(Almacenar en un vector y mostrar) 
         * Empleado que ganó más en cada mes y cuanto fue su salario 
         * Empleado que gano más en el trimestre y cual fue su salario en los tres meses 
         * Nombre de los empleados cuyo salario fue menor que el promedio en el segundo mes
         */
        static void Main(string[] args)
        {

            const int empleados = 25;
            const int meses = 3;

            string[] nombres = new string[empleados];
            float[,] salarios = new float[empleados, meses];
            float[] totalMes = new float[meses];
            float[] promedioEmpleado = new float[empleados];

            InicializarDatos(nombres, salarios);
            CalcularTotalesPorMes(salarios, totalMes);
            CalcularPromediosPorEmpleado(salarios, promedioEmpleado);

            Console.WriteLine("\n--- Salario promedio de todos los empleados ---");
            Console.WriteLine($"Promedio general: {CalcularPromedioGeneral(promedioEmpleado):0.00}");

            Console.WriteLine("\n--- Total a pagar por mes ---");
            for (int m = 0; m < meses; m++)
            {
                Console.WriteLine($"Mes {m + 1}: ${totalMes[m]:0.00}");
            }

            Console.WriteLine("\n--- Empleado que ganó más en cada mes ---");
            for (int m = 0; m < meses; m++)
            {
                int indice = EmpleadoMayorEnMes(salarios, m);
                Console.WriteLine($"Mes {m + 1}: {nombres[indice]} con ${salarios[indice, m]:0.00}");
            }

            Console.WriteLine("\n--- Empleado con mayor ingreso en el trimestre ---");
            int indiceMayorTrimestre = EmpleadoMayorTrimestre(promedioEmpleado);
            float totalTrimestre = 0;
            for (int m = 0; m < meses; m++)
                totalTrimestre += salarios[indiceMayorTrimestre, m];
            Console.WriteLine($"{nombres[indiceMayorTrimestre]} con ${totalTrimestre:0.00}");

            Console.WriteLine("\n--- Empleados con salario menor al promedio en el segundo mes ---");
            float promedioMes2 = totalMes[1] / empleados;
            for (int i = 0; i < empleados; i++)
            {
                if (salarios[i, 1] < promedioMes2)
                    Console.WriteLine($"{nombres[i]} con ${salarios[i, 1]:0.00}");
            }

            Console.ReadKey();
        }

        // Inicializa nombres y salarios con validación
        static void InicializarDatos(string[] nombres, float[,] salarios)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                do
                {
                    Console.Write($"Nombre del empleado {i + 1}: ");
                    nombres[i] = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(nombres[i]));

                for (int m = 0; m < salarios.GetLength(1); m++)
                {
                    do
                    {
                        Console.Write($"Salario del mes {m + 1} para {nombres[i]}: ");
                        if (!float.TryParse(Console.ReadLine(), out salarios[i, m]) || salarios[i, m] < 0)
                        {
                            Console.WriteLine("Ingrese un salario válido (mayor o igual a 0).");
                        }
                    } while (salarios[i, m] < 0);
                }
            }
        }

        // Calcula el total por mes
        static void CalcularTotalesPorMes(float[,] matriz, float[] totalMes)
        {
            for (int m = 0; m < matriz.GetLength(1); m++)
            {
                totalMes[m] = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    totalMes[m] += matriz[i, m];
                }
            }
        }

        // Calcula el promedio por empleado
        static void CalcularPromediosPorEmpleado(float[,] matriz, float[] promedios)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                float suma = 0;
                for (int m = 0; m < matriz.GetLength(1); m++)
                {
                    suma += matriz[i, m];
                }
                promedios[i] = suma / matriz.GetLength(1);
            }
        }

        // Promedio general de todos los empleados
        static float CalcularPromedioGeneral(float[] promedios)
        {
            float suma = 0;
            foreach (float p in promedios)
                suma += p;
            return suma / promedios.Length;
        }

        // Empleado con mayor salario en un mes específico
        static int EmpleadoMayorEnMes(float[,] matriz, int mes)
        {
            int indice = 0;
            float mayor = matriz[0, mes];
            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, mes] > mayor)
                {
                    mayor = matriz[i, mes];
                    indice = i;
                }
            }
            return indice;
        }

        // Empleado con mayor promedio en el trimestre
        static int EmpleadoMayorTrimestre(float[] promedios)
        {
            int indice = 0;
            float mayor = promedios[0];
            for (int i = 1; i < promedios.Length; i++)
            {
                if (promedios[i] > mayor)
                {
                    mayor = promedios[i];
                    indice = i;
                }
            }
            return indice;
        }
        
    }
}
