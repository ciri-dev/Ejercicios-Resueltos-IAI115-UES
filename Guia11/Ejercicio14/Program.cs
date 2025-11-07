using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{   /*
     * 14- La empresa DATASYSTEM desea desarrollar un programa para manejar 
     * la información de sus 10 empleados. La información con que se cuenta 
     * de cada empleado es: nombre, sexo y sueldo. Por tanto, se pide: 
     * Realizar una solución que lea los datos de los 10 empleados de la 
     * empresa y que imprima los datos del empleado con mayor y menor salario.
     */
    internal class Program
    {
        // Estructura para representar un empleado
        public struct Empleado
        {
            public string nombre;
            public char sexo;
            public double sueldo;
        }

        static void Main(string[] args)
        {
            
            Empleado[] empleados = new Empleado[10];
            LeerEmpleados(empleados);

            int indiceMayor = BuscarMayor(empleados);
            int indiceMenor = BuscarMenor(empleados);

            Console.WriteLine("\nEmpleado con mayor salario:");
            MostrarEmpleado(empleados[indiceMayor]);

            Console.WriteLine("\nEmpleado con menor salario:");
            MostrarEmpleado(empleados[indiceMenor]);

            Console.ReadKey();
        }

        // Lee los datos de los empleados
        static void LeerEmpleados(Empleado[] empleados)
        {
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine($"\nEmpleado {i + 1}:");

                Console.Write("Nombre: ");
                empleados[i].nombre = Console.ReadLine();

                Console.Write("Sexo (M/F): ");
                empleados[i].sexo = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                Console.Write("Sueldo: ");
                while (!double.TryParse(Console.ReadLine(), out empleados[i].sueldo) || empleados[i].sueldo < 0)
                {
                    Console.WriteLine("Ingrese un sueldo válido.");
                }
            }
        }

        // Busca el índice del empleado con mayor sueldo
        static int BuscarMayor(Empleado[] empleados)
        {
            int indice = 0;
            for (int i = 1; i < empleados.Length; i++)
            {
                if (empleados[i].sueldo > empleados[indice].sueldo)
                    indice = i;
            }
            return indice;
        }

        // Busca el índice del empleado con menor sueldo
        static int BuscarMenor(Empleado[] empleados)
        {
            int indice = 0;
            for (int i = 1; i < empleados.Length; i++)
            {
                if (empleados[i].sueldo < empleados[indice].sueldo)
                    indice = i;
            }
            return indice;
        }

        // Muestra los datos de un empleado
        static void MostrarEmpleado(Empleado e)
        {
            Console.WriteLine($"Nombre: {e.nombre}");
            Console.WriteLine($"Sexo: {e.sexo}");
            Console.WriteLine($"Sueldo: {e.sueldo:C}");
        }
        
    }
}
