using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    internal class Program
    {   /*
         * 21- Dada la cantidad de productos y el precio por unidad, 
         * calcule y despliegue el total a pagar si el pedido mínimo 
         * de productos es de 500 y se aplican descuentos del 10% 
         * para pedidos de 700 800 ambos inclusive y 20% para pedidos 
         * de más de 800 productos.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            int cantidad;
            double precio, total;

            // entrada de datos
            cantidad = LeerEntero("Ingrese la cantidad de productos:");
            precio = LeerDecimal("Ingrese el precio por unidad:");

            // Validar pedido mínimo
            if (cantidad < 500)
            {
                Console.WriteLine("El pedido mínimo es de 500 productos.");
                return;
            }

            // proceso de datos
            total = CalcularTotal(cantidad, precio);

            // salida de datos
            MostrarResultado(total);
        }

        /// <summary>
        /// Solicita al usuario un número entero (cantidad).
        /// </summary>
        static int LeerEntero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Solicita al usuario un número decimal (precio).
        /// </summary>
        static double LeerDecimal(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calcula el total a pagar aplicando descuentos según la cantidad.
        /// </summary>
        static double CalcularTotal(int cantidad, double precio)
        {
            double subtotal = cantidad * precio;
            double descuento = 0;

            if (cantidad >= 700 && cantidad <= 800)
            {
                descuento = subtotal * 0.10;
            }
            else if (cantidad > 800)
            {
                descuento = subtotal * 0.20;
            }

            return subtotal - descuento;
        }

        /// <summary>
        /// Muestra el total a pagar con formato monetario.
        /// </summary>
        static void MostrarResultado(double total)
        {
            Console.WriteLine($"\nTotal a pagar: ${total:0.00}");
        }
    }
}
