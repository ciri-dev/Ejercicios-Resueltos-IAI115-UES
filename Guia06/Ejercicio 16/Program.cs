using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    internal class Program
    {   /*
         * 16- Diseñe una solución que permita  leer dos números y que 
         * despliegue el número mayor, el número menor o un mensaje de 
         * que los números son iguales.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            double num1, num2;
            string resultado;

            // entrada de datos
            num1 = LeerNumero("Ingrese el primer número:");
            num2 = LeerNumero("Ingrese el segundo número:");

            // proceso de datos
            resultado = CompararNumeros(num1, num2);

            // salida de datos
            MostrarResultado(resultado);
        }

        /// <summary>
        /// Solicita al usuario un número decimal.
        /// </summary>
        static double LeerNumero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Compara dos números y devuelve un mensaje indicando cuál es mayor, menor o si son iguales.
        /// </summary>
        static string CompararNumeros(double a, double b)
        {
            if (a > b)
                return $"\nEl número mayor es: {a} y el menor es: {b}";
            else if (a < b)
                return $"\nEl número mayor es: {b} y el menor es: {a}";
            else
                return "\nAmbos números son iguales.";
        }

        /// <summary>
        /// Muestra el resultado de la comparación en consola.
        /// </summary>
        static void MostrarResultado(string resultado)
        {
            Console.WriteLine(resultado);
        }
    }
}
