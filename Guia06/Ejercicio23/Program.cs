using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{   /*
     * 23- Una tienda vende Agua embotellada en garrafones de 5 galones, a un precio 
     * de $2.50 la unidad. Si la compra es de 10 ó menos unidades no se hace descuento, 
     * pero si es de más de 10 unidades, las primeras 10 cuestan el precio establecido, 
     * las demás tienen un 10% de descuento. Si la compra es mayor de 30, obtiene un 30% 
     * de descuento, tomando como base el precio establecido, exclusivamente sobre las 
     * que pasen de 30. Dado el número de unidades que compra un cliente, calcule y 
     * despliegue el total de la compra, el descuento, y el total a cancelar por la compra. 
     */
    internal class Program
    {
        const double PRECIO_UNITARIO = 2.50;

        static void Main(string[] args)
        {   
            // declaracion de variables
            int cantidad;
            double totalBruto, descuento, totalNeto;

            // entrada de datos
            cantidad = LeerEntero("Ingrese la cantidad de garrafones que desea comprar:");

            // proceso de datos
            totalBruto = cantidad * PRECIO_UNITARIO;
            descuento = CalcularDescuento(cantidad);
            totalNeto = totalBruto - descuento;

            // salida de datos
            MostrarTotales(totalBruto, descuento, totalNeto);
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
        /// Calcula el monto de descuento según la cantidad comprada.
        /// </summary>
        static double CalcularDescuento(int cantidad)
        {
            double descuento = 0;

            if (cantidad > 10 && cantidad <= 30)
            {
                int conDescuento = cantidad - 10;
                descuento = conDescuento * (PRECIO_UNITARIO * 0.10);
            }
            else if (cantidad > 30)
            {
                // 10% para unidades 11–30
                descuento += 20 * (PRECIO_UNITARIO * 0.10);

                // 30% para unidades que excedan 30
                int extra = cantidad - 30;
                descuento += extra * (PRECIO_UNITARIO * 0.30);
            }

            return descuento;
        }

        /// <summary>
        /// Muestra el total bruto, descuento y total neto.
        /// </summary>
        static void MostrarTotales(double bruto, double descuento, double neto)
        {
            Console.WriteLine($"\nTotal sin descuento: ${bruto:0.00}");
            Console.WriteLine($"Descuento aplicado: ${descuento:0.00}");
            Console.WriteLine($"Total a cancelar: ${neto:0.00}");
        }
    }
}
