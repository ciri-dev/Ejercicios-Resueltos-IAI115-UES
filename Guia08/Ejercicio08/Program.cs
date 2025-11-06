using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {   /*
         * 8- Parqueo “El Centro” quiere, a partir de los tiquetes de toda la 
         * semana, calcular el total de ingreso diario y semanal, los tiquetes 
         * están ordenados por dia, pero la cantidad diaria de tiquetes no se 
         * sabe. Diseñe una solución que despliegue el total diario y el total 
         * semanal de ingreso.
         */
        static void Main(string[] args)
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            double totalSemanal = 0;

            for (int i = 0; i < dias.Length; i++)
            {
                double totalDia = ProcesarDia(dias[i]);
                Console.WriteLine($"Total ingreso del día {dias[i]}: ${totalDia:0.00}");
                totalSemanal += totalDia;
            }

            Console.WriteLine($"\nTotal semanal de ingresos: ${totalSemanal:0.00}");
        }

        // Método para procesar los tiquetes de un día
        static double ProcesarDia(string dia)
        {
            double totalDia = 0;
            string respuesta;

            Console.WriteLine($"\nProcesando tiquetes del día {dia}:");

            do
            {
                double monto = LeerMonto();
                totalDia += monto;

                Console.Write("¿Desea ingresar otro tiquete para este día? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            return totalDia;
        }

        // Método para leer y validar el monto de un tiquete
        static double LeerMonto()
        {
            double monto;
            do
            {
                Console.Write("Ingrese el monto del tiquete: $");
                monto = double.Parse(Console.ReadLine());

                if (monto < 0)
                    Console.WriteLine("El monto no puede ser negativo. Intente de nuevo.");

            } while (monto < 0);

            return monto;
        }
        
    }
}
