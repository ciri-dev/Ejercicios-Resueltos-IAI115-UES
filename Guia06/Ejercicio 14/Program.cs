using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    internal class Program
    {   /*
         * 14- Dada la cantidad de televisores ordenada por una comercial a 
         * la fábrica y el precio por unidad, calcule el monto total que 
         * debe pagar la comercial, si el pedido minimo es de 100 unidades, 
         * y se aplica descuento del 5% de 201 a 300 unidades y del 10% de 
         * 301 unidades en adelante.
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            int cantidad;
            double precio, total;

            // entrada de datos
            cantidad = LeerEntero("Ingrese la cantidad de televisores:");
            precio = LeerDecimal("Ingrese el precio por unidad:");

            if (cantidad < 100)
            {
                Console.WriteLine("El pedido mínimo es de 100 unidades.");
                return;
            }

            // proceso de datos
            total = CalcularTotal(cantidad, precio);

            // salida de datos
            MostrarResultado(total);
        }

        /// <summary>
        /// Solicita al usuario un número entero.
        /// </summary>
        static int LeerEntero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Solicita al usuario un número decimal.
        /// </summary>
        static double LeerDecimal(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calcula el total a pagar por la compra de televisores,
        /// aplicando descuentos según la cantidad ordenada.
        /// </summary>
        static double CalcularTotal(int cantidad, double precio)
        {
            double subtotal = cantidad * precio;
            double descuento = 0;

            if (cantidad >= 201 && cantidad <= 300)
            {
                descuento = subtotal * 0.05;
            }
            else if (cantidad > 300)
            {
                descuento = subtotal * 0.10;
            }

            return subtotal - descuento;
        }

        /// <summary>
        /// Muestra en pantalla el total a pagar con formato monetario.
        /// </summary>
        static void MostrarResultado(double total)
        {
            Console.WriteLine($"Total a pagar: ${total:0.00}");
        }
    }
}
