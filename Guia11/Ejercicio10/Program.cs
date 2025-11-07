using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {   /*
         * 10-  Diseñar un programa que convierta una cadena a un valor entero y 
         * valide si sólo posee números. 
         */
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese una cadena que represente un número entero: ");
            string entrada = LeerCadena();

            if (ValidarSoloNumeros(entrada))
            {
                int numero = ConvertirCadena(entrada);
                Console.WriteLine($"\nConversión exitosa. Valor entero: {numero}");
            }
            else
            {
                Console.WriteLine("\nLa cadena contiene caracteres no numéricos.");
            }

            Console.ReadKey();
        }

        // Lee una cadena no vacía
        static string LeerCadena()
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(texto))
                    Console.WriteLine("La cadena no puede estar vacía.");
            } while (string.IsNullOrWhiteSpace(texto));
            return texto;
        }

        // Valida que la cadena contenga solo dígitos
        static bool ValidarSoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        // Convierte la cadena a entero (asumiendo que ya fue validada)
        static int ConvertirCadena(string texto)
        {
            return int.Parse(texto);
        }
        
    }
}
