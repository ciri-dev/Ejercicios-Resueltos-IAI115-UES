using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{   /*
     * 7- Según norma de la EPA el nivel máximo permisible de plomo en aire es de 
     * 0.15 µg/m3; dado un conjunto de puntos y dadas las mediciones de plomo 
     * hechas en aire en cada punto. Desplegar, si los hay, los puntos donde la 
     * medición sobrepasa el nivel permitido.
     */
    internal class Program
    {
        const double LIMITE_EPA = 0.15;

        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de puntos de medición: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                double medicion = LeerMedicion(i);

                if (medicion > LIMITE_EPA)
                {
                    Console.WriteLine($"Punto #{i} excede el límite: {medicion} µg/m³");
                }
            }

            Console.WriteLine("Proceso finalizado.");
        }

        // Método para leer y validar una medición
        static double LeerMedicion(int punto)
        {
            double valor;
            do
            {
                Console.Write($"Ingrese la medición de plomo en aire para el punto #{punto} (µg/m³): ");
                valor = double.Parse(Console.ReadLine());

                if (valor < 0)
                    Console.WriteLine("La medición no puede ser negativa. Intente de nuevo.");

            } while (valor < 0);

            return valor;
        }
        
    }
}
