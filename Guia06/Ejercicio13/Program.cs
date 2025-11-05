using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        /*
         * 13- Diseñe una solución que dado el radio de un disco, la base y altura
         * de un rectángulo, calcule y despliegue la circunferencia del disco y el 
         * perímetro del rectángulo así como el área del disco y el área del 
         * rectángulo. Los radios y longitudes deben ser positivos y la base 
         * diferente a la altura.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            double radio, baseRect, alturaRect;

            // entrada de datos
            radio = LeerDato("Ingrese el radio del disco:");
            baseRect = LeerDato("Ingrese la base del rectángulo:");
            alturaRect = LeerDato("Ingrese la altura del rectángulo:");

            // Validación de datos
            if (radio <= 0 || baseRect <= 0 || alturaRect <= 0)
            {
                Console.WriteLine("Todos los valores deben ser positivos.");
                return;
            }

            if (baseRect == alturaRect)
            {
                Console.WriteLine("La base y la altura del rectángulo deben ser diferentes.");
                return;
            }

            // proceso de datos
            double circunferencia = 2 * Math.PI * radio;
            double areaDisco = Math.PI * Math.Pow(radio, 2);
            double perimetroRect = 2 * (baseRect + alturaRect);
            double areaRect = baseRect * alturaRect;

            // salida de datos
            Console.WriteLine($"\nCircunferencia del disco: {circunferencia:0.00}");
            Console.WriteLine($"Área del disco: {areaDisco:0.00}");
            Console.WriteLine($"Perímetro del rectángulo: {perimetroRect:0.00}");
            Console.WriteLine($"Área del rectángulo: {areaRect:0.00}");
        }

        /// <summary>
        /// Solicita al usuario un número decimal positivo.
        /// </summary>
        static double LeerDato(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }
    }
}
