using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {   /*
         * 11- En la empresa “REGALONA S.A.” se dará una bonificación para los empleados 
         * por haber logrado el premio de mejor empresa del año, de acuerdo al cargo que 
         * desempeñan y al tiempo de trabajo laborado de la siguiente forma: 
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            string nombre, cargo;
            int anios;
            double salario, porcentaje, bonificacion;

            // entrada de datos
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el cargo (Gerente, Jefe, Técnico, Secretaria): ");
            cargo = Console.ReadLine().Trim().ToLower();

            Console.Write("Ingrese los años de servicio: ");
            anios = Convert.ToInt32(Console.ReadLine());

            // Obtener salario base según cargo
            salario = ObtenerSalarioBase(cargo);

            // Validar cargo
            if (salario == 0)
            {
                Console.WriteLine("Error: Cargo no reconocido.");
                return;
            }

            // proceso de datos
            porcentaje = ObtenerPorcentajeBonificacion(cargo, anios);
            bonificacion = salario * porcentaje;

            // salida de datos
            Console.WriteLine($"\nEmpleado: {nombre}");
            Console.WriteLine($"Cargo: {cargo.ToUpper()}");
            Console.WriteLine($"Años de servicio: {anios}");
            Console.WriteLine($"Bonificación: ${bonificacion:F2}");
        }

        // Método para obtener salario base según cargo
        static double ObtenerSalarioBase(string cargo)
        {
            switch (cargo)
            {
                case "gerente": return 2500.00;
                case "jefe": return 2000.00;
                case "tecnico": return 1300.00;
                case "secretaria": return 600.00;
                default: return 0;
            }
        }

        // Método para obtener porcentaje de bonificación
        static double ObtenerPorcentajeBonificacion(string cargo, int anios)
        {
            switch (cargo)
            {
                case "gerente":
                    if (anios < 5) return 0.10;
                    else if (anios <= 10) return 0.15;
                    else return 0.20;

                case "jefe":
                    if (anios < 5) return 0.08;
                    else if (anios <= 10) return 0.12;
                    else return 0.17;

                case "tecnico":
                    if (anios < 5) return 0.05;
                    else if (anios <= 10) return 0.08;
                    else return 0.13;

                case "secretaria":
                    if (anios < 5) return 0.04;
                    else if (anios <= 10) return 0.05;
                    else return 0.10;

                default:
                    return 0;
            }
        }
    }
}
