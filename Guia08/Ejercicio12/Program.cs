using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {   /*
         * 12- Diseñe una solución que dada la cantidad n de años permite ingresar 
         * las ventas trimestrales de una tienda por departamentos. y que imprima 
         * las ventas totales por año.
         */
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de años a procesar: ");
            int cantidadAnios = int.Parse(Console.ReadLine());

            for (int anio = 1; anio <= cantidadAnios; anio++)
            {
                Console.WriteLine($"\n--- Año #{anio} ---");
                double totalAnual = ProcesarVentasAnuales(anio);
                Console.WriteLine($"Total de ventas del año #{anio}: ${totalAnual:0.00}");
            }
        }

        // Método para procesar las ventas de un año
        static double ProcesarVentasAnuales(int anio)
        {
            double suma = 0;

            for (int trimestre = 1; trimestre <= 4; trimestre++)
            {
                double venta = LeerVenta(anio, trimestre);
                suma += venta;
            }

            return suma;
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
