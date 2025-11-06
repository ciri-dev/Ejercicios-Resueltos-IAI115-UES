using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {   /*
         * 14- Diseñe una solución que dada la cantidad de años lea para cada 
         * año el monto de cada una de las compras de petróleo en $ (la 
         * cantidad de compras por año varía); se debe imprimir el promedio 
         * por año y el total en los n años.
         */
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de años a procesar: ");
            int cantidadAnios = int.Parse(Console.ReadLine());

            double totalGlobal = 0;

            for (int anio = 1; anio <= cantidadAnios; anio++)
            {
                Console.WriteLine($"\n--- Año #{anio} ---");
                double totalAnual = 0;
                int compras = 0;
                string respuesta;

                do
                {
                    double monto = LeerCompra(compras + 1);
                    totalAnual += monto;
                    compras++;

                    Console.Write("¿Desea ingresar otra compra para este año? (s/n): ");
                    respuesta = Console.ReadLine().ToLower();

                } while (respuesta == "s");

                double promedio = (compras > 0) ? totalAnual / compras : 0;
                Console.WriteLine($"\nPromedio de compras en año #{anio}: ${promedio:0.00}");
                totalGlobal += totalAnual;
            }

            Console.WriteLine($"Total acumulado en los {cantidadAnios} años: ${totalGlobal:0.00}");
        }

        // Método para leer y validar el monto de una compra
        static double LeerCompra(int indice)
        {
            double monto;
            do
            {
                Console.Write($"Ingrese el monto de la compra #{indice}: $");
                monto = double.Parse(Console.ReadLine());

                if (monto < 0)
                    Console.WriteLine("El monto no puede ser negativo. Intente de nuevo.");

            } while (monto < 0);

            return monto;
        }
        
    }
}
