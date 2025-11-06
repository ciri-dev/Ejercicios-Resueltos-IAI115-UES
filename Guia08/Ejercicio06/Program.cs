using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {   /*
         * 6- Se ingresan las temperaturas de cada dia de la semana, determinar e informar: 
         * a. Promedio de temperatura semanal 
         * b. El día mas frio y el más caluroso 
         * c. Porcentaje de temperaturas bajo cero
         */
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            LeerTemperaturas(temperaturas, dias);
            double promedio = CalcularPromedio(temperaturas);
            int diaFrio = DiaMasFrio(temperaturas);
            int diaCaluroso = DiaMasCaluroso(temperaturas);
            double porcentajeBajoCero = PorcentajeBajoCero(temperaturas);

            Console.WriteLine($"\nPromedio semanal: {promedio:0.00}°C");
            Console.WriteLine($"Día más frío: {dias[diaFrio]} ({temperaturas[diaFrio]}°C)");
            Console.WriteLine($"Día más caluroso: {dias[diaCaluroso]} ({temperaturas[diaCaluroso]}°C)");
            Console.WriteLine($"Porcentaje de días bajo cero: {porcentajeBajoCero:0.00}%");
        }

        // Método para leer temperaturas
        static void LeerTemperaturas(double[] temps, string[] dias)
        {
            for (int i = 0; i < temps.Length; i++)
            {
                Console.Write($"Ingrese la temperatura del día {dias[i]}: ");
                temps[i] = double.Parse(Console.ReadLine());
            }
        }

        // Método para calcular el promedio
        static double CalcularPromedio(double[] temps)
        {
            double suma = 0;
            foreach (double t in temps)
            {
                suma += t;
            }
            return suma / temps.Length;
        }

        // Método para encontrar el índice del día más frío
        static int DiaMasFrio(double[] temps)
        {
            int indice = 0;
            for (int i = 1; i < temps.Length; i++)
            {
                if (temps[i] < temps[indice])
                    indice = i;
            }
            return indice;
        }

        // Método para encontrar el índice del día más caluroso
        static int DiaMasCaluroso(double[] temps)
        {
            int indice = 0;
            for (int i = 1; i < temps.Length; i++)
            {
                if (temps[i] > temps[indice])
                    indice = i;
            }
            return indice;
        }

        // Método para calcular el porcentaje de días bajo cero
        static double PorcentajeBajoCero(double[] temps)
        {
            int contador = 0;
            foreach (double t in temps)
            {
                if (t < 0)
                    contador++;
            }
            return (contador * 100.0) / temps.Length;
        }

        
    }
}
