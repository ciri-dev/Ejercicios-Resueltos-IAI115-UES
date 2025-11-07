using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {   /*
         * 7- Se tienen las 6 calificaciones de 25 alumnos de Programación I, 
         * se necesita calcular lo siguiente: 
         * La nota promedio de cada examen  
         * El promedio final de cada alumno  
         * El mayor promedio final de los alumnos.
         */
        static void Main(string[] args)
        {

            const int alumnos = 25;
            const int examenes = 6;

            float[,] notas = new float[alumnos, examenes];
            float[] promedioAlumno = new float[alumnos];
            float[] promedioExamen = new float[examenes];

            LeerNotas(notas);
            CalcularPromedioPorAlumno(notas, promedioAlumno);
            CalcularPromedioPorExamen(notas, promedioExamen);

            Console.WriteLine("\n--- Promedio de cada examen ---");
            for (int i = 0; i < examenes; i++)
            {
                Console.WriteLine($"Examen {i + 1}: {promedioExamen[i]:0.00}");
            }

            Console.WriteLine("\n--- Promedio final de cada alumno ---");
            for (int i = 0; i < alumnos; i++)
            {
                Console.WriteLine($"Alumno {i + 1}: {promedioAlumno[i]:0.00}");
            }

            int indiceMayor = ObtenerIndiceMayor(promedioAlumno);
            Console.WriteLine($"\nEl alumno con mayor promedio final es el Alumno {indiceMayor + 1} con {promedioAlumno[indiceMayor]:0.00}");

            Console.ReadKey();
        }

        // Método para leer y validar las calificaciones
        static void LeerNotas(float[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"\nAlumno {i + 1}:");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        Console.Write($"Nota del Examen {j + 1}: ");
                        if (!float.TryParse(Console.ReadLine(), out matriz[i, j]) || matriz[i, j] < 0 || matriz[i, j] > 10)
                        {
                            Console.WriteLine("Ingrese una nota válida entre 0 y 10.");
                        }
                    } while (matriz[i, j] < 0 || matriz[i, j] > 10);
                }
            }
        }

        // Calcula el promedio final de cada alumno
        static void CalcularPromedioPorAlumno(float[,] matriz, float[] promedios)
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

        // Calcula el promedio de cada examen
        static void CalcularPromedioPorExamen(float[,] matriz, float[] promedios)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                float suma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    suma += matriz[i, j];
                }
                promedios[j] = suma / matriz.GetLength(0);
            }
        }

        // Devuelve el índice del alumno con mayor promedio
        static int ObtenerIndiceMayor(float[] vector)
        {
            int indice = 0;
            float mayor = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                    indice = i;
                }
            }
            return indice;
        }
    }
}
