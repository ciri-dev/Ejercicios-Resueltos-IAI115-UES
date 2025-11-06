using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Program
    {   /*
         * 25- Desplegar por pantalla la cantidad de horas acumuladas de 1 a 7 días.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de horas acumuladas de 1 a 7 días:");

            for (int dia = 1; dia <= 7; dia++)
            {
                int horas = dia * 24;
                Console.WriteLine($"{dia} día(s) → {horas} horas");
            }
        }
    }
}
