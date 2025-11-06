using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    internal class Program
    {   /*
         * 21- Desplegar por pantalla la cantidad de meses acumulados de 1 a 15 años.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de meses acumulados de 1 a 15 años:");

            for (int anio = 1; anio <= 15; anio++)
            {
                int meses = anio * 12;
                Console.WriteLine($"{anio} año(s) → {meses} meses");
            }
        }
    }
}
