using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{   /*
     * 9- Se desea conocer la siguiente información de una empresa: 
     * Imprimir toda la nómina de empleados ordenados por un número correlativo. 
     * Cuantos empleados ganan más de $1500.00 
     * Cuántos entre  $850.00 y $1500.oo 
     * Cuantos menos de $850.00 
     * Porcentaje de empleados con salarios menores de $850.oo 
     * Porcentaje de empleados cuyo salario oscila entre $850.oo y $1000.oo 
     * Porcentaje de empleados con salario mayor a $1000.oo 
     * Diseñe el programa correspondiente utilizando vectores.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] salarios = new double[20];

            Console.WriteLine("=== Registro de salarios de empleados ===");
            LeerSalarios(salarios);

            Console.WriteLine("\n=== Nómina de empleados ===");
            ImprimirNomina(salarios);

            int mas1500 = ContarPorCondicion(salarios, s => s > 1500);
            int entre850y1500 = ContarPorCondicion(salarios, s => s >= 850 && s <= 1500);
            int menos850 = ContarPorCondicion(salarios, s => s < 850);

            Console.WriteLine($"\nEmpleados que ganan más de $1500.00: {mas1500}");
            Console.WriteLine($"Empleados que ganan entre $850.00 y $1500.00: {entre850y1500}");
            Console.WriteLine($"Empleados que ganan menos de $850.00: {menos850}");

            double porcentajeMenos850 = CalcularPorcentaje(salarios, s => s < 850);
            double porcentajeEntre850y1000 = CalcularPorcentaje(salarios, s => s >= 850 && s <= 1000);
            double porcentajeMas1000 = CalcularPorcentaje(salarios, s => s > 1000);

            Console.WriteLine($"\nPorcentaje con salario < $850.00: {porcentajeMenos850:F2}%");
            Console.WriteLine($"Porcentaje entre $850.00 y $1000.00: {porcentajeEntre850y1000:F2}%");
            Console.WriteLine($"Porcentaje con salario > $1000.00: {porcentajeMas1000:F2}%");
        }

        // Método para leer salarios con validación
        static void LeerSalarios(double[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Ingrese salario del empleado #{i + 1}: ");
                arreglo[i] = LeerSalarioPositivo();
            }
        }

        // Validación de salario positivo
        static double LeerSalarioPositivo()
        {
            double salario;
            while (!double.TryParse(Console.ReadLine(), out salario) || salario < 0)
            {
                Console.Write("Entrada inválida. Ingrese un salario positivo: ");
            }
            return salario;
        }

        // Imprimir nómina con número correlativo
        static void ImprimirNomina(double[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Empleado #{i + 1}: ${arreglo[i]:F2}");
            }
        }

        // Contar empleados según condición
        static int ContarPorCondicion(double[] arreglo, Func<double, bool> condicion)
        {
            int contador = 0;
            foreach (double salario in arreglo)
            {
                if (condicion(salario))
                    contador++;
            }
            return contador;
        }

        // Calcular porcentaje según condición
        static double CalcularPorcentaje(double[] arreglo, Func<double, bool> condicion)
        {
            int cantidad = ContarPorCondicion(arreglo, condicion);
            return (double)cantidad * 100 / arreglo.Length;
        }
        
    }
}
