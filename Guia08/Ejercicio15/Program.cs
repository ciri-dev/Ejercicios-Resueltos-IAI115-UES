using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {   /*
         * 15- Diseñe una solución que dada la cantidad n de años permite ingresar 
         * las ventas trimestrales de una tienda por departamentos. y que imprima 
         * la venta más alta y el año/trimestre respectivo.
         */
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de años a procesar: ");
            int cantidadAnios = int.Parse(Console.ReadLine());

            double ventaMaxima = 0;
            int anioMax = 0;
            int trimestreMax = 0;

            for (int anio = 1; anio <= cantidadAnios; anio++)
            {
                Console.WriteLine($"\n--- Año #{anio} ---");

                for (int trimestre = 1; trimestre <= 4; trimestre++)
                {
                    double venta = LeerVenta(anio, trimestre);

                    if (venta > ventaMaxima)
                    {
                        ventaMaxima = venta;
                        anioMax = anio;
                        trimestreMax = trimestre;
                    }
                }
            }

            Console.WriteLine($"\nLa venta más alta fue de ${ventaMaxima:0.00} en el año #{anioMax}, trimestre #{trimestreMax}.");
        }

        // Método para leer y validar una venta trimestral
        static double LeerVenta(int anio, int trimestre)
        {
            double venta;
            do
            {
                Console.Write($"Ingrese la venta del trimestre #{trimestre} del año #{anio}: $");
                venta = double.Parse(Console.ReadLine());

                if (venta < 0)
                    Console.WriteLine("La venta no puede ser negativa. Intente de nuevo.");

            } while (venta < 0);

            return venta;
        }
        
    }
}
