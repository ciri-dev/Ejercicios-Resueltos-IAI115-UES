using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {   /*
         * 6- Diseñe una solución que dado el sexo de una persona y el día de la semana 
         * imprima el valor de la entrada a una discoteca. El precio para hombres es de 
         * $10 y para mujer es de $5, pero dependiendo del día de la semana, se tienen 
         * los siguientes descuentos: para hombres: Domingo 50%, Jueves 10%, Martes 30% 
         * y para mujer: Lunes, Miércoles y Sábado se hace 50%. Además el Viernes las 
         * mujeres entran gratis.
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            char sexo;
            string dia;
            double precioBase, descuento, precioFinal;

            // entrada de datos
            Console.Write("Ingrese el sexo (H para hombre, M para mujer): ");
            sexo = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Ingrese el día de la semana (ej. lunes): ");
            dia = Console.ReadLine().ToLower();

            // Validación
            if (!EsSexoValido(sexo) || !EsDiaValido(dia))
            {
                Console.WriteLine("Error: Sexo o día inválido.");
                return;
            }

            // proceso de datos
            precioBase = ObtenerPrecioBase(sexo);
            descuento = ObtenerDescuento(sexo, dia);
            precioFinal = Math.Round(precioBase * (1 - descuento), 2);

            // salida de datos
            Console.WriteLine($"\nSexo: {(sexo == 'H' ? "Hombre" : "Mujer")}");
            Console.WriteLine($"Día: {dia}");
            Console.WriteLine($"Precio base: ${precioBase}");
            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
            Console.WriteLine($"Precio final: ${precioFinal}");
        }

        // Verifica si el sexo ingresado es válido
        static bool EsSexoValido(char sexo)
        {
            return sexo == 'H' || sexo == 'M';
        }

        // Verifica si el día ingresado es válido
        static bool EsDiaValido(string dia)
        {
            string[] diasValidos = { "lunes", "martes", "miércoles", "jueves", "viernes", "sábado", "domingo" };

            foreach (string d in diasValidos)
            {
                if (d == dia)
                {
                    return true;
                }
            }

            return false;
        }

        // Retorna el precio base según el sexo
        static double ObtenerPrecioBase(char sexo)
        {
            return sexo == 'H' ? 10.0 : 5.0;
        }

        // Retorna el descuento según sexo y día
        static double ObtenerDescuento(char sexo, string dia)
        {
            if (sexo == 'H')
            {
                switch (dia)
                {
                    case "domingo": return 0.50;
                    case "martes": return 0.30;
                    case "jueves": return 0.10;
                    default: return 0.0;
                }
            }
            else // Mujer
            {
                switch (dia)
                {
                    case "lunes":
                    case "miércoles":
                    case "sábado": return 0.50;
                    case "viernes": return 1.0; // Entrada gratis
                    default: return 0.0;
                }
            }
        }
    }
}
