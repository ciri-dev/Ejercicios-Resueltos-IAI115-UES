using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Program
    {   /*
         * 8- Diseñe una solución que calcule y despliegue la raíz cuadrada de un número. Sí el número es
         * negativo, debe desplegar la raíz imaginaria en la forma ai, donde i=√-1 Ejemplo: √-4 = 2i
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            double numero;
            string resultado;

            // entrada de datos
            numero = LeerNumero("Ingrese un número para calcular su raíz cuadrada:");

            // proceso de datos
            resultado = CalcularRaiz(numero);

            // salida de datos
            MostrarResultado(resultado);
        }

        /// <summary>
        /// Solicita al usuario un número real.
        /// </summary>
        static double LeerNumero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calcula la raíz cuadrada si el número es positivo,
        /// o la raíz imaginaria si es negativo.
        /// </summary>
        static string CalcularRaiz(double num)
        {
            if (num >= 0)
            {
                double raiz = Math.Sqrt(num);
                return $"\nLa raíz cuadrada de {num} es {raiz:0.00}";
            }
            else
            {
                double raizImaginaria = Math.Sqrt(Math.Abs(num));
                return $"\nLa raíz cuadrada de {num} es {raizImaginaria:0.00}i";
            }
        }

        /// <summary>
        /// Muestra el resultado en consola.
        /// </summary>
        static void MostrarResultado(string resultado)
        {
            Console.WriteLine(resultado);
        }
    }
}
