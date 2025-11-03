using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    /*
     * 19- En la Facultad de Ingeniería y Arquitectura, los alumnos que obtengan
     * una nota de ciclo entre 5.0 y 5.94 inclusive, tienen derecho a realizar 
     * un examen de Suficiencia con el cual tienen la opción de aprobar la asignatura. 
     * Diseñe una solución que permita conocer a partir del promedio del estudiante, 
     * si califica o no para hacer el examen de Suficiencia. También se debe reportar
     * si el alumno aprobó o reprobó, con el promedio proporcionado.
     */
    internal class Program
    {
        static void Main(string[] args)
        {   
            // declaracion de variables
            double promedio;
            string resultado;

            // entrada de datos
            promedio = LeerPromedio("Ingrese el promedio del estudiante:");

            // proceso de datos
            resultado = EvaluarEstado(promedio);

            // salida de datos
            MostrarResultado(resultado);
        }

        /// <summary>
        /// Solicita al usuario el promedio del estudiante.
        /// </summary>
        static double LeerPromedio(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Determina si el estudiante aprueba, califica para suficiencia o reprueba.
        /// </summary>
        static string EvaluarEstado(double promedio)
        {
            if (promedio >= 6.0)
            {
                return $"\nPromedio: {promedio:0.00} → El estudiante ha aprobado la asignatura.";
            }
            else if (promedio >= 5.0 && promedio <= 5.94)
            {
                return $"\nPromedio: {promedio:0.00} → El estudiante califica para examen de Suficiencia.";
            }
            else
            {
                return $"\nPromedio: {promedio:0.00} → El estudiante ha reprobado la asignatura.";
            }
        }

        /// <summary>
        /// Muestra el resultado en consola.
        /// </summary>
        static void MostrarResultado(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
