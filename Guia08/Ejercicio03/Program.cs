using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {   /*
         * 3- Pedir dos números y mostrar todos los números pares que van 
         * desde el primero al segundo. Se debe controlar que los valores 
         * son correctos.
         */
        static void Main(string[] args)
        {
            int inicio = LeerNumero("Ingrese el primer número: ");
            int fin = LeerNumero("Ingrese el segundo número (mayor o igual al primero): ");

            // Validación: el segundo número debe ser mayor o igual al primero
            while (fin < inicio)
            {
                Console.WriteLine("El segundo número debe ser mayor o igual al primero.");
                fin = LeerNumero("Ingrese nuevamente el segundo número: ");
            }

            MostrarParesEnRango(inicio, fin);
        }

        // Método para leer y validar un número entero
        static int LeerNumero(string mensaje)
        {
            int numero;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. Intente de nuevo: ");
            }
            return numero;
        }

        // Método para mostrar los números pares entre inicio y fin
        static void MostrarParesEnRango(int inicio, int fin)
        {
            Console.WriteLine($"\nNúmeros pares entre {inicio} y {fin}:");
            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine(); 
        }
    }
}
