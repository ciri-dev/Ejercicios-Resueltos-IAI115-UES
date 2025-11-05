using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{   /*
     * 2- Para la realización del segundo examen parcial de Introducción a la Informática 
     * se exigirá que cada estudiante haya asistido a, por lo menos, el 75% de las 8 clases 
     * teóricas y 4 sesiones de laboratorios a evaluar. Dado el carnet del estudiante y sus 
     * respectivas asistencias, despliegue carnet, porcentaje de asistencia de cada tipo de 
     * actividad y si tiene derecho a realizar el examen.
     */
    internal class Program
    {
        // Constantes de asistencia mínima
        const int TOTAL_TEORICAS = 8;
        const int TOTAL_LABORATORIOS = 4;
        const double MINIMO_TEORICAS = 0.75;
        const double MINIMO_LABORATORIOS = 0.75;

        static void Main(string[] args)
        {
            // declaracion de variables
            string carnet;
            int asistenciasTeoricas, asistenciasLaboratorios;

            // entrada de datos
            Console.Write("Ingrese el carnet del estudiante: ");
            carnet = Console.ReadLine();

            Console.Write("Ingrese número de asistencias a clases teóricas (0-8): ");
            asistenciasTeoricas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número de asistencias a laboratorios (0-4): ");
            asistenciasLaboratorios = int.Parse(Console.ReadLine());

            // Validación de datos
            if (EsValido(asistenciasTeoricas, TOTAL_TEORICAS) && EsValido(asistenciasLaboratorios, TOTAL_LABORATORIOS))
            {
                // proceso de datos
                double porcentajeTeoricas = CalcularPorcentaje(asistenciasTeoricas, TOTAL_TEORICAS);
                double porcentajeLaboratorios = CalcularPorcentaje(asistenciasLaboratorios, TOTAL_LABORATORIOS);

                // Evaluación de derecho a examen
                bool tieneDerecho = TieneDerechoExamen(asistenciasTeoricas, asistenciasLaboratorios);

                // salida de datos
                Console.WriteLine($"\nCarnet: {carnet}");
                Console.WriteLine($"Asistencia Teórica: {porcentajeTeoricas}%");
                Console.WriteLine($"Asistencia Laboratorio: {porcentajeLaboratorios}%");
                Console.WriteLine($"¿Tiene derecho a examen?: {(tieneDerecho ? "Sí" : "No")}");
            }
            else
            {
                Console.WriteLine("\nError: Las asistencias ingresadas están fuera del rango permitido.");
            }
        }

        // Verifica si el número de asistencias es válido
        static bool EsValido(int asistencias, int total)
        {
            return asistencias >= 0 && asistencias <= total;
        }

        // Calcula el porcentaje de asistencia
        static double CalcularPorcentaje(int asistencias, int total)
        {
            return Math.Round((double)asistencias / total * 100, 2);
        }

        // Determina si el estudiante tiene derecho a examen
        static bool TieneDerechoExamen(int teoricas, int laboratorios)
        {
            return teoricas >= TOTAL_TEORICAS * MINIMO_TEORICAS &&
                   laboratorios >= TOTAL_LABORATORIOS * MINIMO_LABORATORIOS;
        }
    }
}
