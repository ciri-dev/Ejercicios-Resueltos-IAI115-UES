using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    internal class Program
    {   /*
         * 19- Desplegar por pantalla los primeros 15 números positivos múltiplos 
         * de 5 y que son impares
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Primeros 15 números positivos múltiplos de 5 e impares:");

            int contador = 0;
            int numero = 1;

            while (contador < 15)
            {
                if (numero % 5 == 0 && numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                    contador++;
                }
                numero++;
            }
        }
    }
}
