using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {   /*
         * 8- Dada la cantidad en metros imprima la representación en la unidad más próxima 
         * sin pasarse (sistema internacional hasta petametros). Ejemplo 999 Mts-> 999 Mts; 
         * 2000 Mts->2 Kilómetros
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            double metros, valorConvertido;
            string unidad;

            // entrada de datos
            Console.Write("Ingrese la cantidad en metros: ");
            metros = double.Parse(Console.ReadLine());

            // Validación
            if (metros < 0)
            {
                Console.WriteLine("Error: La cantidad debe ser positiva.");
                return;
            }

            // proceso de datos
            unidad = DeterminarUnidad(metros);
            valorConvertido = Convertir(metros, unidad);

            // salida de datos
            Console.WriteLine($"\n{valorConvertido} {unidad}");
        }

        // Determina la unidad más próxima sin pasarse
        static string DeterminarUnidad(double metros)
        {
            if (metros < 1_000) return "m";
            else if (metros < 1_000_000) return "km";
            else if (metros < 1_000_000_000) return "Mm";
            else if (metros < 1_000_000_000_000) return "Gm";
            else if (metros < 1_000_000_000_000_000) return "Tm";
            else return "Pm";
        }

        // Convierte los metros a la unidad correspondiente
        static double Convertir(double metros, string unidad)
        {
            switch (unidad)
            {
                case "m": return metros;
                case "km": return Math.Round(metros / 1_000, 2);
                case "Mm": return Math.Round(metros / 1_000_000, 2);
                case "Gm": return Math.Round(metros / 1_000_000_000, 2);
                case "Tm": return Math.Round(metros / 1_000_000_000_000, 2);
                case "Pm": return Math.Round(metros / 1_000_000_000_000_000, 2);
                default: return metros;
            }
        }
    }
}
