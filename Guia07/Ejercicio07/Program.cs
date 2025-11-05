using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {   /*
         * 7- BancoCredit ofrece préstamos a un plazo mínimo de 1 año y máximo de 5 años plazo, a 
         * empleados públicos o privados. El monto del crédito es 2 veces el salario por cada año 
         * plazo para públicos y 1.5 para privados. Dado salario, plazo y tipo de empleado cuánto 
         * se puede prestar, si el monto no puede ser menor a $600.00 y el salario no menor de $300.00?
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            double salario, monto;
            int plazo;
            char tipo;

            // Entrada de datos
            Console.Write("Ingrese el salario mensual: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el plazo en años (1 a 5): ");
            plazo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tipo de empleado (P para público, R para privado): ");
            tipo = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // Validación
            if (!EsSalarioValido(salario) || !EsPlazoValido(plazo) || !EsTipoValido(tipo))
            {
                Console.WriteLine("\nError: Datos inválidos.");
                return;
            }

            // proceso de datos
            monto = CalcularMonto(salario, plazo, tipo);

            // Verificación del minimo y salida de datos
            if (monto < 600.00)
            {
                Console.WriteLine("\nMonto calculado: $" + monto);
                Console.WriteLine("No cumple con el monto mínimo requerido ($600.00).");
            }
            else
            {
                Console.WriteLine("\nMonto aprobado: $" + monto);
            }
        }

        // Verifica si el salario es válido
        static bool EsSalarioValido(double salario)
        {
            return salario >= 300.00;
        }

        // Verifica si el plazo está entre 1 y 5 años
        static bool EsPlazoValido(int plazo)
        {
            return plazo >= 1 && plazo <= 5;
        }

        // Verifica si el tipo de empleado es válido
        static bool EsTipoValido(char tipo)
        {
            return tipo == 'P' || tipo == 'R';
        }

        // Calcula el monto del préstamo según tipo de empleado
        static double CalcularMonto(double salario, int plazo, char tipo)
        {
            if (tipo == 'P') // Público
                return 2 * salario * plazo;
            else // Privado
                return 1.5 * salario * plazo;
        }
    }
}
