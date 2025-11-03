using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    internal class Program
    {   /*
         * 17- Dadas las coordenadas de un punto en el plano cartesiano, despliegue 
         * un mensaje indicando en qué cuadrante se encuentra ó si está en el 
         * eje x, ó en eje y, ó en el origen.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            double x, y;
            string ubicacion;

            // entrada de datos
            x = LeerCoordenada("Ingrese la coordenada X:");
            y = LeerCoordenada("Ingrese la coordenada Y:");

            // proceso de datos
            ubicacion = DeterminarUbicacion(x, y);

            // salida de datos
            MostrarResultado(ubicacion);
        }

        /// <summary>
        /// Solicita al usuario una coordenada (X o Y).
        /// </summary>
        static double LeerCoordenada(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Evalúa en qué parte del plano cartesiano se encuentra el punto.
        /// </summary>
        static string DeterminarUbicacion(double x, double y)
        {
            if (x == 0 && y == 0)
                return "\nEl punto está en el origen.";
            else if (x == 0)
                return "\nEl punto está sobre el eje Y.";
            else if (y == 0)
                return "\nEl punto está sobre el eje X.";
            else if (x > 0 && y > 0)
                return "\nEl punto está en el primer cuadrante.";
            else if (x < 0 && y > 0)
                return "\nEl punto está en el segundo cuadrante.";
            else if (x < 0 && y < 0)
                return "\nEl punto está en el tercer cuadrante.";
            else // x > 0 && y < 0
                return "\nEl punto está en el cuarto cuadrante.";
        }

        /// <summary>
        /// Muestra el mensaje de ubicación en consola.
        /// </summary>
        static void MostrarResultado(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
