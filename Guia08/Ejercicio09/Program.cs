using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {   /*
         * 9- Dada la cantidad de estudiantes y la cantidad de notas por estudiante 
         * imprima el promedio de cada estudiante, la cantidad y porcentaje 
         * de aprobados.
         */
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de notas por estudiante: ");
            int cantidadNotas = int.Parse(Console.ReadLine());

            int aprobados = 0;

            for (int i = 1; i <= cantidadEstudiantes; i++)
            {
                Console.WriteLine($"\nEstudiante #{i}:");
                double promedio = CalcularPromedioEstudiante(cantidadNotas);
                Console.WriteLine($"Promedio: {promedio:0.00}");

                if (promedio >= 6.0)
                    aprobados++;
            }

            double porcentaje = (aprobados * 100.0) / cantidadEstudiantes;
            Console.WriteLine($"\nCantidad de aprobados: {aprobados}");
            Console.WriteLine($"Porcentaje de aprobados: {porcentaje:0.00}%");
        }

        // Método para calcular el promedio de un estudiante
        static double CalcularPromedioEstudiante(int cantidadNotas)
        {
            double suma = 0;

            for (int j = 1; j <= cantidadNotas; j++)
            {
                double nota = LeerNota(j);
                suma += nota;
            }

            return suma / cantidadNotas;
        }

        // Método para leer y validar una nota
        static double LeerNota(int indice)
        {
            double nota;
            do
            {
                Console.Write($"Ingrese la nota #{indice} (0 a 10): ");
                nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10)
                    Console.WriteLine("Nota inválida. Debe estar entre 0 y 10.");

            } while (nota < 0 || nota > 10);

            return nota;
        }
    }
}
