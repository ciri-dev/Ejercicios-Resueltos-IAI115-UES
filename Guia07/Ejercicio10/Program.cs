using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {   /*
         * 10- Diseñe una calculadora básica que dados dos números y dada la operación 
         * a realizar (suma, resta, producto o división), despliegue el resultado o 
         * mensaje de error en caso que no pueda realizarse. 
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            double numero1, numero2;
            char operacion;

            // entrada de datos
            Console.Write("Ingrese el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la operación (+, -, *, /): ");
            operacion = Console.ReadLine().Trim()[0];

            // Validación de operación
            if (EsOperacionValida(operacion))
            {
                // Validación especial para división entre cero
                if (operacion == '/' && !EsDivisorValido(numero2))
                {
                    Console.WriteLine("\nError: No se puede dividir entre cero.");
                }
                else
                {
                    double resultado = CalcularResultado(numero1, numero2, operacion);
                    Console.WriteLine($"\nResultado: {numero1} {operacion} {numero2} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("\nERROR: Operación no reconocida. Use +, -, * o /.");
            }
        }

        // Método para validar operación
        static bool EsOperacionValida(char op)
        {
            return op == '+' || op == '-' || op == '*' || op == '/';
        }

        // Método para validar divisor en división
        static bool EsDivisorValido(double divisor)
        {
            return divisor != 0;
        }

        // Método para calcular el resultado según la operación
        static double CalcularResultado(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: return 0; 
            }
        }
    }
}
