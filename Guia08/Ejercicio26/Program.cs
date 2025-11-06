using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    internal class Program
    {   /*
         * 26- Desplegar por pantalla la cantidad de segundos acumulados de 1 a 12 horas.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de segundos acumulados de 1 a 12 horas:");

            for (int hora = 1; hora <= 12; hora++)
            {
                int segundos = hora * 3600;
                Console.WriteLine($"{hora} hora(s) → {segundos} segundos");
            }
        }
    }
}
