using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{   /*
     * 1- El almacén “París” desea registrar el total de sus ventas diarias de 
     * un mes, para poder obtener:  
     * el promedio de ventas diario,  
     * la menor venta efectuada y el día del mes que se ejecutó,  
     * la mayor venta efectuada y el día del mes en el que se ejecutó,  
     * total de ventas del mes 
     * Pronóstico de ventas para todo el año, considerando venta promedio diaria 
       Considere meses de 30 días.
     */
    internal class Program
    {
        const int DIAS_DEL_MES = 30;
        static void Main(string[] args)
        {
            double[] ventasDiarias = new double[DIAS_DEL_MES];

            Console.WriteLine("Registro de ventas diarias del almacén París\n");

            // entrada de datos
            LeerVentas(ventasDiarias);

            // proceso de datos
            double total = CalcularTotalVentas(ventasDiarias);
            double promedio = CalcularPromedioVentas(total);
            int diaMenor = EncontrarDiaMenorVenta(ventasDiarias);
            int diaMayor = EncontrarDiaMayorVenta(ventasDiarias);
            double pronosticoAnual = promedio * 365;

            // salida de datos
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Total de ventas del mes: ${total:F2}");
            Console.WriteLine($"Promedio diario de ventas: ${promedio:F2}");
            Console.WriteLine($"Menor venta: ${ventasDiarias[diaMenor]:F2} en el día {diaMenor + 1}");
            Console.WriteLine($"Mayor venta: ${ventasDiarias[diaMayor]:F2} en el día {diaMayor + 1}");
            Console.WriteLine($"Pronóstico de ventas anual: ${pronosticoAnual:F2}");
        }

        // Función para leer y validar las ventas diarias
        static void LeerVentas(double[] ventas)
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                double valor;
                do
                {
                    Console.Write($"Ingrese la venta del día {i + 1}: $");
                    string entrada = Console.ReadLine();
                    if (!double.TryParse(entrada, out valor) || valor < 0)
                    {
                        Console.WriteLine("Entrada inválida. Ingrese un número positivo.");
                    }
                } while (valor < 0);
                ventas[i] = valor;
            }
        }

        // Función para calcular el total de ventas
        static double CalcularTotalVentas(double[] ventas)
        {
            double suma = 0;
            foreach (double venta in ventas)
            {
                suma += venta;
            }
            return suma;
        }

        // Función para calcular el promedio diario
        static double CalcularPromedioVentas(double total)
        {
            return total / DIAS_DEL_MES;
        }

        // Función para encontrar el día con menor venta
        static int EncontrarDiaMenorVenta(double[] ventas)
        {
            int dia = 0;
            for (int i = 1; i < ventas.Length; i++)
            {
                if (ventas[i] < ventas[dia])
                    dia = i;
            }
            return dia;
        }

        // Función para encontrar el día con mayor venta
        static int EncontrarDiaMayorVenta(double[] ventas)
        {
            int dia = 0;
            for (int i = 1; i < ventas.Length; i++)
            {
                if (ventas[i] > ventas[dia])
                    dia = i;
            }
            return dia;
        }
        
    }
}
