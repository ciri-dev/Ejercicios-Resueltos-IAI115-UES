using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    internal class Program
    {   /*
         * 24- Zapatería ABC hace descuentos del 15% en el total de la compra, 
         * si cumple uno de los siguientes criterios: compró más de 3 pares ó 
         * el monto total de la compra es mayor a $100. Dado el monto de la compra 
         * en dólares y la cantidad de pares comprados, calcule y despliegue el 
         * total a pagar.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            int pares;
            double monto, descuento, total;

            // entrada de datos
            pares = LeerEntero("Ingrese la cantidad de pares comprados:");
            monto = LeerDecimal("Ingrese el monto total de la compra ($):");

            // Calcular descuento y total a pagar
            descuento = 0;
            if (pares > 3 || monto > 100)
            {
                descuento = monto * 0.15;
            }

            total = monto - descuento;

            // salida de datos
            MostrarResultado(descuento, total);
        }

        /// <summary>
        /// Solicita al usuario un número entero (cantidad de pares).
        /// </summary>
        static int LeerEntero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Solicita al usuario un número decimal (monto total).
        /// </summary>
        static double LeerDecimal(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Muestra el descuento aplicado y el total a pagar.
        /// </summary>
        static void MostrarResultado(double descuento, double total)
        {
            Console.WriteLine($"\nDescuento aplicado: ${descuento:0.00}");
            Console.WriteLine($"Total a pagar: ${total:0.00}");
        }
    }
}
