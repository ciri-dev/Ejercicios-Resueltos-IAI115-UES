using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    internal class Program
    {   /*
         * 30- Desplegar por pantalla la sumatoria de los primeros 10 números enteros negativos
         */
        static void Main(string[] args)
        {
            int suma = 0;

            for (int i = -1; i >= -10; i--)
            {
                suma += i;
            }

            Console.WriteLine($"La sumatoria de los primeros 10 números enteros negativos es: {suma}");
        
        }
    }
}
