using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    internal class Program
    {   /*
         * 22- Desplegar por pantalla la cantidad de minutos acumulados de 1 a 12 horas
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de minutos acumulados de 1 a 12 horas:");

            for (int hora = 1; hora <= 12; hora++)
            {
                int minutos = hora * 60;
                Console.WriteLine($"{hora} hora(s) → {minutos} minutos");
            }
        }
    }
}
