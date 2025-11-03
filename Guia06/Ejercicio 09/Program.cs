using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    internal class Program
    {   /*
         * 9- Diseñe una solución que dado el tiempo en segundos, lo calcule en términos de días, 
         * horas y minutos. Ejemplo: 1 Día 3 Horas 2 Minutos, pero sí la cantidad es cero no debe 
         * desplegarse. Ejemplo: 1 Día 7 Minutos  (la cantidad de Horas es cero)
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            int segundos, dias, horas, minutos;
            int restoHoras, restoDias;

            // entrada de datos
            segundos = LeerEntero("Ingrese el tiempo en segundos:");

            // proceso de datos
            dias = segundos / 86400;
            restoDias = segundos % 86400;

            horas = restoDias / 3600;
            restoHoras = restoDias % 3600;

            minutos = restoHoras / 60;

            // salida de datos
            MostrarTiempo(dias, horas, minutos);
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
        /// Muestra días, horas y minutos si su valor es mayor que cero.
        /// </summary>
        static void MostrarTiempo(int dias, int horas, int minutos)
        {
            if (dias > 0) Console.Write($"\n{dias} Día{(dias > 1 ? "s" : "")} ");
            if (horas > 0) Console.Write($"{horas} Hora{(horas > 1 ? "s" : "")} ");
            if (minutos > 0) Console.Write($"{minutos} Minuto{(minutos > 1 ? "s" : "")} ");
            if (dias == 0 && horas == 0 && minutos == 0) Console.Write("0 Minutos");

            Console.WriteLine();
        }
    }
}
