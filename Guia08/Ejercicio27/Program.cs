using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    internal class Program
    {   /*
         * 27- Desplegar por pantalla la cantidad de días acumulados de 1 a 7 años.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de días acumulados de 1 a 7 años:");

            for (int anio = 1; anio <= 7; anio++)
            {
                int dias = anio * 365;
                Console.WriteLine($"{anio} año(s) → {dias} días");
            }
        }
    }
}
