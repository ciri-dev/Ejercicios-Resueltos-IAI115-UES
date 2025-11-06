using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    internal class Program
    {   /*
         * 23- Desplegar por pantalla la cantidad de segundos acumulados de 1 a 10 minutos.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de segundos acumulados de 1 a 10 minutos:");

            for (int minuto = 1; minuto <= 10; minuto++)
            {
                int segundos = minuto * 60;
                Console.WriteLine($"{minuto} minuto(s) → {segundos} segundos");
            }
        }
    }
}
