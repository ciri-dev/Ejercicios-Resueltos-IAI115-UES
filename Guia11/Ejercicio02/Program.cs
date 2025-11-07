using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {   /*
         * 2- Concatenar cuatro cadenas de caracteres utilizando la función Concat().
         */
        static void Main(string[] args)
        {
          
            Console.WriteLine("Ingrese cuatro cadenas para concatenar:");
            string c1 = LeerCadena("Cadena 1");
            string c2 = LeerCadena("Cadena 2");
            string c3 = LeerCadena("Cadena 3");
            string c4 = LeerCadena("Cadena 4");

            string resultado = ConcatenarCadenas(c1, c2, c3, c4);
            Console.WriteLine($"\nResultado concatenado: {resultado}");

            Console.ReadKey();
        }

        // Lee una cadena con etiqueta y valida que no esté vacía
        static string LeerCadena(string etiqueta)
        {
            string texto;
            do
            {
                Console.Write($"{etiqueta}: ");
                texto = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(texto))
                    Console.WriteLine("La cadena no puede estar vacía.");
            } while (string.IsNullOrWhiteSpace(texto));
            return texto;
        }

        // Une cuatro cadenas usando String.Concat()
        static string ConcatenarCadenas(string a, string b, string c, string d)
        {
            return String.Concat(a, " ", b, " ", c, " ", d);
        }
        
    }
}
