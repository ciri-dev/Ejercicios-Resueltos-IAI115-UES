using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{   /*
     * 15- Dados el nombre, salario y puesto de un empleado, calcule y despliegue
     * el Bono Navideño en dólares. Bonos->Gerente 30% Supervisor 20% Asistente 15% 
     * Secretaria 10% Ordenanza 5%
     */
    internal class Program
    {
        static void Main(string[] args)
        {   
            // declaracion de variables
            string nombre, puesto;
            double salario, bono;

            // entrada de datos
            nombre = LeerTexto("Ingrese el nombre del empleado: ");
            salario = LeerDecimal("Ingrese el salario del empleado: $");
            puesto = LeerTexto("Ingrese el puesto del empleado (Gerente, Supervisor, Asistente, Secretaria, Ordenanza):");
            bono = CalcularBono(puesto, salario);

            // salida de datos
            MostrarResultado(nombre, puesto, bono);
        }

        /// <summary>
        /// Solicita al usuario una entrada de texto (nombre o puesto).
        /// </summary>
        static string LeerTexto(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        /// <summary>
        /// Solicita al usuario un número decimal (salario).
        /// </summary>
        static double LeerDecimal(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calcula el bono navideño según el puesto del empleado.
        /// </summary>
        static double CalcularBono(string puesto, double salario)
        {
            double porcentaje = 0;

            // Estructura selectiva para determinar el porcentaje
            if (puesto.ToLower() == "gerente")
                porcentaje = 0.30;
            else if (puesto.ToLower() == "supervisor")
                porcentaje = 0.20;
            else if (puesto.ToLower() == "asistente")
                porcentaje = 0.15;
            else if (puesto.ToLower() == "secretaria")
                porcentaje = 0.10;
            else if (puesto.ToLower() == "ordenanza")
                porcentaje = 0.05;

            return salario * porcentaje;
        }

        /// <summary>
        /// Muestra el nombre, puesto y bono navideño del empleado.
        /// </summary>
        static void MostrarResultado(string nombre, string puesto, double bono)
        {
            Console.WriteLine($"\nEmpleado: {nombre}");
            Console.WriteLine($"Puesto: {puesto}");
            Console.WriteLine($"Bono Navideño: ${bono:0.00}");
        }
    }
}
