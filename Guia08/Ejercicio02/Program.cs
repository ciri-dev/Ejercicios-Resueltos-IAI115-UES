using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {   /*
         * 2- Pedir un número entero del rango entre 1 y 15 y muestre en pantalla 
         * el mismo número de asteriscos.
         */
        static void Main()
        {
            int cantidad = ValidarNumero();
            MostrarAsteriscos(cantidad);
        }

        // Método para validar que el número esté entre 1 y 15
        static int ValidarNumero()
        {
            int numero;
            do
            {
                Console.Write("Ingrese un número entre 1 y 15: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero < 1 || numero > 15);

            return numero;
        }

        // Método para imprimir la cantidad de asteriscos
        static void MostrarAsteriscos(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Salto de línea al final
        }
    }
}
