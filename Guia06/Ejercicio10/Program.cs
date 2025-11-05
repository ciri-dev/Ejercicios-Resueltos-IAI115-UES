using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        /*
         * 10- Diseñe una solución que dada una distancia en Millas, la calcule en términos de 
         * Kilómetros, Metros y Centímetros. Ejemplo: 1 Km 3 Mts 2 Cms, pero sí la cantidad es 
         * cero no debe desplegarse. Ejemplo: 3 Mts  (la cantidad de Kms y de Cms es cero)
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            double millas, totalCm;
            int km, restoKm, m, cm;

            // entrada de datos
            millas = LeerDecimal("Ingrese la distancia en millas:");

            // proceso de datos
            totalCm = millas * 160934; // 1 milla = 160934 cm

            // Calcular kilómetros, metros y centímetros
            km = (int)(totalCm / 100000);
            restoKm = (int)(totalCm % 100000);

            m = restoKm / 100;
            cm = restoKm % 100;

            // salida de datos
            MostrarDistancia(km, m, cm);
        }

        /// <summary>
        /// Solicita al usuario un número decimal.
        /// </summary>
        static double LeerDecimal(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Muestra kilómetros, metros y centímetros si su valor es mayor que cero.
        /// </summary>
        static void MostrarDistancia(int km, int m, int cm)
        {
            if (km > 0) Console.Write($"\n{km} Km ");
            if (m > 0) Console.Write($"{m} Mts ");
            if (cm > 0) Console.Write($"{cm} Cms ");
            if (km == 0 && m == 0 && cm == 0) Console.Write("0 Cms");

            Console.WriteLine();
        }
    }
}
