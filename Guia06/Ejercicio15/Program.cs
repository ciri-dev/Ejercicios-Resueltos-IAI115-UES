using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{   /*
     * 15- Dados el nombre, salario y puesto de un empleado, calcule y despliegue el 
     * Bono Navideño en dólares. Bonos->Gerente 30% Supervisor 20% Asistente 15% 
     * Secretaria 10% Ordenanza 5%.
     */
    internal class Program
    {       
            // declaracion de constantes
            const double GERENTE = 0.3, SUPERVISOR = 0.25, ASISTENTE = 0.15;
            const double SECRETARIA = 0.10, ORDENANZA = 0.05;
            static void Main(string[] args)
            {
                // declaracion de variables
                string nombre;
                int opcion;
                double salario, bono;

                // entrada de datos
                Console.Write("Ingrese su nombre completo: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese el valor de su salario: $");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine("\nElija la opcion acuerdo a su puesto de trabajo.\n 1- Gerente\n 2- Supervisor\n 3- Asistente\n 4- Secretaria\n 5- Ordenanza");
                opcion = int.Parse(Console.ReadLine());

                // proceso y salida de datos
                bono = CalcularBono(salario, opcion);
                if (salario > 0 && (opcion >= 1 && opcion <= 5))
                {   
                    Console.WriteLine("\n{0} su bono navideño es de {1:C} dolares", nombre, bono);
                }
                else
                {
                    Console.WriteLine("\nNo se pudo calcular su bono navideño. Vuelva a intentarlo");
                }
                Console.ReadKey();
            }

            // Metodo para calcular el bono dependiendo del tipo de empleado
            static double CalcularBono(double salario, double opcion)
            {
                double bono = 0;
                if (opcion == 1)
                {
                    bono = salario * GERENTE;
                }
                else if (opcion == 2)
                {
                    bono = salario * SUPERVISOR;
                }
                else if (opcion == 3)
                {
                    bono = salario * ASISTENTE;
                }
                else if (opcion == 4)
                {
                    bono = salario * SECRETARIA;
                }
                else if (opcion == 5)
                {
                    bono = salario * ORDENANZA;
                }
                return bono;
            }
       
    }
}
