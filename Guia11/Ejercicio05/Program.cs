using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {   /*
         * 5- Se comparan dos palabras y se despliega la más larga.
         */
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese la primera palabra: ");
            string palabra1 = LeerPalabra();

            Console.Write("Ingrese la segunda palabra: ");
            string palabra2 = LeerPalabra();

            MostrarMasLarga(palabra1, palabra2);

            Console.ReadKey();
        }

        // Lee una palabra no vacía
        static string LeerPalabra()
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(texto))
                    Console.WriteLine("La palabra no puede estar vacía.");
            } while (string.IsNullOrWhiteSpace(texto));
            return texto;
        }

        // Compara las longitudes y muestra la palabra más larga
        static void MostrarMasLarga(string a, string b)
        {
            if (a.Length > b.Length)
                Console.WriteLine($"\nLa palabra más larga es: {a}");
            else if (b.Length > a.Length)
                Console.WriteLine($"\nLa palabra más larga es: {b}");
            else
                Console.WriteLine("\nLas palabras tienen el mismo tamanio.");
        }
        
    }
}
