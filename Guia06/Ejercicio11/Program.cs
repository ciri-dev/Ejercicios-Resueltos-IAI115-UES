using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        /*
         * 11- Diseñe una solución que dadas dos temperaturas (máxima y mínima) en grados 
         * centígrados las convierta a grados fahrenheit y   grados kelvin. Debe mostrar 
         * las temperaturas original y las conversiones en pantalla, con sus respectivos 
         * mensajes de entrada y salida.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            double tempMax, tempMin;

            // entrada de datos
            tempMax = LeerTemperatura("Ingrese la temperatura máxima en °C:");
            tempMin = LeerTemperatura("Ingrese la temperatura mínima en °C:");

            // proceso y salida de datos
            MostrarConversion("Temperatura Máxima", tempMax);
            MostrarConversion("Temperatura Mínima", tempMin);
        }

        /// <summary>
        /// Solicita al usuario una temperatura en grados centígrados.
        /// </summary>
        static double LeerTemperatura(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Convierte grados centígrados a Fahrenheit.
        /// </summary>
        static double ConvertirAFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        /// <summary>
        /// Convierte grados centígrados a Kelvin.
        /// </summary>
        static double ConvertirAKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        /// <summary>
        /// Muestra la temperatura original y sus conversiones.
        /// </summary>
        static void MostrarConversion(string etiqueta, double celsius)
        {
            double fahrenheit = ConvertirAFahrenheit(celsius);
            double kelvin = ConvertirAKelvin(celsius);

            Console.WriteLine($"\n{etiqueta}:");
            Console.WriteLine($"Centígrados: {celsius:0.00} °C");
            Console.WriteLine($"Fahrenheit: {fahrenheit:0.00} °F");
            Console.WriteLine($"Kelvin: {kelvin:0.00} K");
        }
    }
}
