using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    internal class Program
    {   /*
         * 22- Diseñe una solución que dado dos puntos en la recta numérica 
         * muestre un mensaje indicando si ambos están en el segmento positivo 
         * o ambos están en el segmento negativo o si están en diferente 
         * segmento, NO se permite que ingrese puntos ubicados en el origen o 
         * punto cero.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            double punto1, punto2;
            string resultado;

            // entrada de datos
            punto1 = LeerNumero("Ingrese el primer punto (!= 0):");
            punto2 = LeerNumero("Ingrese el segundo punto (!= 0):");

            // Validar que ninguno sea cero
            if (punto1 == 0 || punto2 == 0)
            {
                Console.WriteLine("\nNo se permite ingresar puntos ubicados en el origen (valor cero).");
                return;
            }

            // proceso de datos
            resultado = EvaluarSegmento(punto1, punto2);

            // salida de datos
            MostrarResultado(resultado);
        }

        /// <summary>
        /// Solicita al usuario un número real.
        /// </summary>
        static double LeerNumero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Evalúa si los puntos están en el mismo segmento o en segmentos diferentes.
        /// </summary>
        static string EvaluarSegmento(double x, double y)
        {
            if (x > 0 && y > 0)
                return "\nAmbos puntos están en el segmento positivo.";
            else if (x < 0 && y < 0)
                return "\nAmbos puntos están en el segmento negativo.";
            else
                return "\nLos puntos están en segmentos diferentes.";
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
