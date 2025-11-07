using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {   /*
         * 1- Comparar dos cadenas de caracteres haciendo uso de la función Compare().
         */
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese la primera cadena: ");
            string cadena1 = LeerCadena();

            Console.Write("Ingrese la segunda cadena: ");
            string cadena2 = LeerCadena();

            CompararCadenas(cadena1, cadena2);

            Console.ReadKey();
        }

        // Lee y valida que la cadena no esté vacía
        static string LeerCadena()
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(texto))
                {
                    Console.WriteLine("La cadena no puede estar vacía. Intente de nuevo:");
                }
            } while (string.IsNullOrWhiteSpace(texto));
            return texto;
        }

        // Compara dos cadenas usando String.Compare() y muestra el resultado
        static void CompararCadenas(string a, string b)
        {
            int resultado = String.Compare(a, b);

            Console.WriteLine($"\nResultado de comparar \"{a}\" con \"{b}\": {resultado}");

            if (resultado < 0)
            {
                Console.WriteLine($"\"{a}\" aparece antes que \"{b}\" en orden alfabético.");
            }
            else if (resultado == 0)
            {
                Console.WriteLine("Las cadenas son iguales.");
            }
            else
            {
                Console.WriteLine($"\"{a}\" aparece después que \"{b}\" en orden alfabético.");
            }
        }
        
    }
}
