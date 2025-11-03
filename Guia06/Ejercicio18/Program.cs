using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {   /*
         * 18- Dado el número de apartamento en un complejo de edificios, 
         * despliegue el edificio, la planta o nivel y el número de puerta 
         * dentro de dicho nivel al que corresponde el departamento. Son 7 
         * edificios, cada edificio es de 7 plantas y posee 7 apartamentos 
         * por planta o nivel. Diseñe ud. el número de apartamento dentro 
         * del cual debe poder identificarse edificio, nivel y número de puerta.
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            int numero, edificio, planta, puerta;

            // entrada de datos
            numero = LeerEntero("Ingrese el número de apartamento (1 a 343):");

            if (numero < 1 || numero > 343)
            {
                Console.WriteLine("Número inválido. Debe estar entre 1 y 343.");
                return;
            }

            // proceso de datos
            edificio = ((numero - 1) / 49) + 1;
            planta = (((numero - 1) % 49) / 7) + 1;
            puerta = ((numero - 1) % 7) + 1;

            // salida de datos
            MostrarUbicacion(edificio, planta, puerta);
        }

        /// <summary>
        /// Solicita al usuario un número entero.
        /// </summary>
        static int LeerEntero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Muestra la ubicación del apartamento en el complejo.
        /// </summary>
        static void MostrarUbicacion(int edificio, int planta, int puerta)
        {
            Console.WriteLine($"\nUbicación del apartamento:");
            Console.WriteLine($"Edificio: {edificio}");
            Console.WriteLine($"Planta: {planta}");
            Console.WriteLine($"Puerta: {puerta}");
        }
    }
}
