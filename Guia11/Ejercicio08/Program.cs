using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {   /*
         * 8- Escribir una solución que lea una frase del teclado y que despliegue 
         * el número de palabras que contiene la frase.
         */
        static void Main(string[] args)
        {
           
            Console.Write("Ingrese una frase: ");
            string frase = LeerFrase();

            int cantidad = ContarPalabras(frase);
            Console.WriteLine($"\nLa frase contiene {cantidad} palabra(s).");

            Console.ReadKey();
        }

        // Lee una frase no vacía
        static string LeerFrase()
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(texto))
                    Console.WriteLine("La frase no puede estar vacía.");
            } while (string.IsNullOrWhiteSpace(texto));
            return texto;
        }

        // Cuenta las palabras separadas por espacios en la frase
        static int ContarPalabras(string frase)
        {
            string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
        
    }
}
