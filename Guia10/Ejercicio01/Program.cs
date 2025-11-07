using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {   /*
         * 1- Se tienen las 4 calificaciones de cada uno de 5 alumnos, se necesita 
         * conocer: el promedio de cada estudiante y el promedio de todos.
         */
        static void Main(string[] args)
        {
            const int numAlumnos = 5;
            const int numNotas = 4;

            // Matriz para almacenar las calificaciones
            float[,] calificaciones = new float[numAlumnos, numNotas];

            // Vector para almacenar el promedio de cada alumno
            float[] promediosIndividuales = new float[numAlumnos];

            // Entrada de datos
            LeerCalificaciones(calificaciones);

            // Cálculo de promedios individuales
            CalcularPromediosIndividuales(calificaciones, promediosIndividuales);

            // Mostrar resultados
            MostrarPromedios(promediosIndividuales);

            // Cálculo y muestra del promedio general
            float promedioGeneral = CalcularPromedioGeneral(promediosIndividuales);
            Console.WriteLine($"\nPromedio general del grupo: {promedioGeneral:F2}");
        }

        /// <summary>
        /// Lee las calificaciones de cada alumno y las valida.
        /// </summary>
        static void LeerCalificaciones(float[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"\nAlumno #{i + 1}");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    float nota;
                    do
                    {
                        Console.Write($"Ingrese nota #{j + 1}: ");
                    } while (!float.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10);

                    matriz[i, j] = nota;
                }
            }
        }

        /// <summary>
        /// Calcula el promedio de cada alumno.
        /// </summary>
        static void CalcularPromediosIndividuales(float[,] matriz, float[] promedios)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                float suma = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    suma += matriz[i, j];
                }
                promedios[i] = suma / matriz.GetLength(1);
            }
        }

        /// <summary>
        /// Muestra el promedio de cada alumno.
        /// </summary>
        static void MostrarPromedios(float[] promedios)
        {
            Console.WriteLine("\nPromedios individuales:");
            for (int i = 0; i < promedios.Length; i++)
            {
                Console.WriteLine($"Alumno #{i + 1}: {promedios[i]:F2}");
            }
        }

        /// <summary>
        /// Calcula el promedio general del grupo.
        /// </summary>
        static float CalcularPromedioGeneral(float[] promedios)
        {
            float sumaTotal = 0;
            foreach (float promedio in promedios)
            {
                sumaTotal += promedio;
            }
            return sumaTotal / promedios.Length;
        }
        
    }
}
