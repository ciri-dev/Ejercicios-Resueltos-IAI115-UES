using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {   /*
         * 4- Un número es perfecto si la suma de sus divisores menores a él 
         * es el mismo número, por ejemplo: 28 = 1 + 2 + 4 + 7 + 14. Leer n 
         * números enteros y determinar si son o no perfectos.
         */
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos números desea verificar? ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                int numero = LeerNumero(i);
                bool esPerfecto = VerificarPerfecto(numero);
                MostrarResultado(numero, esPerfecto);
            }
        }

        // Método para leer un número entero positivo
        static int LeerNumero(int indice)
        {
            int numero;
            do
            {
                Console.Write($"Ingrese el número #{indice}: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0);
            return numero;
        }

        // Método para verificar si un número es perfecto
        static bool VerificarPerfecto(int numero)
        {
            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }
            return suma == numero;
        }

        // Método para mostrar el resultado
        static void MostrarResultado(int numero, bool esPerfecto)
        {
            if (esPerfecto)
                Console.WriteLine($"{numero} es un número perfecto.");
            else
                Console.WriteLine($"{numero} NO es un número perfecto.");
        }
        
    }
}
