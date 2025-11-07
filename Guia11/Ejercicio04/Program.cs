using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {   /*
         * 4- Se lee una cadena de caracteres. Luego, se leen dos caracteres 
         * digitados por el usuario. Se pide, realizar un programa que sustituya
         * el primer caracter leído dentro de la cadena por el segundo.
         */
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese una cadena de texto: ");
            string cadena = LeerCadena();

            Console.Write("Ingrese el carácter a reemplazar: ");
            char original = LeerCaracter();

            Console.Write("Ingrese el nuevo carácter: ");
            char nuevo = LeerCaracter();

            string resultado = SustituirCaracter(cadena, original, nuevo);

            Console.WriteLine($"\nCadena resultante: {resultado}");

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

        // Lee un solo carácter desde consola
        static char LeerCaracter()
        {
            char c;
            string entrada;
            do
            {
                entrada = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada) || entrada.Length != 1)
                    Console.WriteLine("Ingrese un solo carácter válido:");
            } while (entrada.Length != 1);
            c = entrada[0];
            return c;
        }

        // Sustituye todas las apariciones de un carácter por otro
        static string SustituirCaracter(string cadena, char original, char nuevo)
        {
            return cadena.Replace(original, nuevo);
        }
        
    }
}
