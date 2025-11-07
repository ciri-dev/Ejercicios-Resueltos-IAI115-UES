using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {   /*
         * 6- Se leen dos palabras por separado y se despliega la de menos caracteres 
         * en minúsculas y en mayúsculas la más larga; si las palabras son de la 
         * misma longitud solamente se indica mediante el mensaje: “Las Cadenas son Iguales”.
         */
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese la primera palabra: ");
            string palabra1 = LeerPalabra();

            Console.Write("Ingrese la segunda palabra: ");
            string palabra2 = LeerPalabra();

            CompararYTransformar(palabra1, palabra2);

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

        // Compara las longitudes y transforma según el resultado
        static void CompararYTransformar(string a, string b)
        {
            if (a.Length == b.Length)
            {
                Console.WriteLine("\nLas Cadenas son Iguales.");
            }
            else if (a.Length < b.Length)
            {
                Console.WriteLine($"\nMenor: {a.ToLower()}");
                Console.WriteLine($"Mayor: {b.ToUpper()}");
            }
            else
            {
                Console.WriteLine($"\nMenor: {b.ToLower()}");
                Console.WriteLine($"Mayor: {a.ToUpper()}");
            }
        }
        
    }
}
