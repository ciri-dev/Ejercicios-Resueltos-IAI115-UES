using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {   /*
         * 7- Se leen diez nombres de frutas y se despliegan sólo las que sus 
         * nombres comiencen con m, reportando la cantidad de frutas seleccionadas
         */
        static void Main(string[] args)
        {
   
            string[] frutas = new string[10];
            LeerFrutas(frutas);
            FiltrarFrutas(frutas, 'm');

            Console.ReadKey();
        }

        // Lee los nombres de frutas desde consola
        static void LeerFrutas(string[] frutas)
        {
            for (int i = 0; i < frutas.Length; i++)
            {
                Console.Write($"Ingrese el nombre de la fruta {i + 1}: ");
                frutas[i] = Console.ReadLine().Trim();
            }
        }

        // Filtra y muestra las frutas que comienzan con una letra específica
        static void FiltrarFrutas(string[] frutas, char inicial)
        {
            int contador = 0;
            Console.WriteLine($"\nFrutas que comienzan con '{inicial}':");
            foreach (string fruta in frutas)
            {
                if (!string.IsNullOrWhiteSpace(fruta) && fruta.ToLower().StartsWith(inicial.ToString()))
                {
                    Console.WriteLine($"- {fruta}");
                    contador++;
                }
            }
            Console.WriteLine($"\nTotal de frutas seleccionadas: {contador}");
        }
        
    }
}
