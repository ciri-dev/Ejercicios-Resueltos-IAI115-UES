using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    internal class Program
    {   /*
         * 20- En un cine se hace un 50% de descuento en el valor de la 
         * entrada a las personas mayores de 60 años y a los menores de 
         * 18 años, el resto de personas (18-60) paga el monto sin 
         * descuento. Dadas la edad y el precio del boleto, calcule cuánto 
         * pagará una persona por su entrada.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            int edad;
            double precio, pago;

            // entrada de datos
            edad = LeerEntero("Ingrese la edad de la persona:");
            precio = LeerDecimal("Ingrese el precio del boleto ($):");
            pago = CalcularPago(edad, precio);

            // salida de datos
            MostrarResultado(pago);
        }

        /// <summary>
        /// Solicita al usuario un número entero (edad).
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
        /// Calcula el monto a pagar aplicando descuento si la edad es menor de 18 o mayor de 60.
        /// </summary>
        static double CalcularPago(int edad, double precio)
        {
            if (edad < 18 || edad > 60)
            {
                return precio * 0.5; // 50% de descuento
            }
            else
            {
                return precio; // Sin descuento
            }
        }

        /// <summary>
        /// Muestra el monto final a pagar.
        /// </summary>
        static void MostrarResultado(double pago)
        {
            Console.WriteLine($"\nMonto a pagar: ${pago:0.00}");
        }
    }
}
