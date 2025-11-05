using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {   /*
         * 3- Dada una cantidad en bytes imprimir su representación en la unidad más próxima sin pasarse.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            double bytes, valorConvertido;
            string unidad;

            
            // entrada de datos
            Console.Write("Ingrese la cantidad en bytes: ");
            bytes = double.Parse(Console.ReadLine());

            // Validación
            if (bytes < 0)
            {
                Console.WriteLine("Error: La cantidad debe ser positiva.");
                return;
            }

            // proceso de datos
            unidad = DeterminarUnidad(bytes);
            valorConvertido = Convertir(bytes, unidad);

            // salida de datos
            Console.WriteLine($"{valorConvertido} {unidad}");
        }

        // Determina la unidad más próxima sin pasarse
        static string DeterminarUnidad(double bytes)
        {
            if (bytes < 1_000) return "B";
            else if (bytes < 1_000_000) return "KB";
            else if (bytes < 1_000_000_000) return "MB";
            else if (bytes < 1_000_000_000_000) return "GB";
            else if (bytes < 1_000_000_000_000_000) return "TB";
            else return "PB";
        }

        // Convierte los bytes a la unidad correspondiente
        static double Convertir(double bytes, string unidad)
        {
            switch (unidad)
            {
                case "B": return bytes;
                case "KB": return Math.Round(bytes / 1_000, 2);
                case "MB": return Math.Round(bytes / 1_000_000, 2);
                case "GB": return Math.Round(bytes / 1_000_000_000, 2);
                case "TB": return Math.Round(bytes / 1_000_000_000_000, 2);
                case "PB": return Math.Round(bytes / 1_000_000_000_000_000, 2);
                default: return bytes;
            }
        }
    }
}
