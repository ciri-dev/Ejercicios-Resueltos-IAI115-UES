using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{   /*
     * 9- La Cooperativa de la Clase Trabajadora, ofrece préstamos a un plazo 
     * mínimo de 2 años y máximo de 7 años plazo, a empleados públicos, privados
     * o independientes. El monto del crédito es 2 veces el salario por cada año 
     * plazo para públicos, 1.5 para privados y 1 salario por año plazo para 
     * independientes. Dado el salario, plazo y tipo de empleado cuánto se puede 
     * prestar, si el monto no puede ser menor a $500.00?
     */
    internal class Program
    {
        // Constante para el monto mínimo permitido
        const double MONTO_MINIMO = 500.00;
        static void Main(string[] args)
        {   
            // declaracion de variables
            double salario;
            int plazo;
            char tipo;

            // entrada de datos
            Console.WriteLine("=== Cooperativa de la Clase Trabajadora ===");
            Console.Write("Ingrese el salario mensual: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el plazo en años (2 a 7): ");
            plazo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tipo de empleado (P = Público, R = Privado, I = Independiente): ");
            tipo = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // Validación de datos
            if (EsSalarioValido(salario) && EsPlazoValido(plazo) && EsTipoValido(tipo))
            {
                double montoPrestamo = CalcularMontoPrestamo(salario, plazo, tipo);

                // Verificación del monto mínimo
                if (montoPrestamo >= MONTO_MINIMO)
                {
                    Console.WriteLine($"\nMonto aprobado: ${montoPrestamo:F2}");
                }
                else
                {
                    Console.WriteLine("\nEl monto calculado no cumple con el mínimo requerido de $500.00.");
                }
            }
            else
            {
                Console.WriteLine("\nError en los datos ingresados.");
                if (!EsSalarioValido(salario))
                    Console.WriteLine("- El salario debe ser mayor a $0.00");
                if (!EsPlazoValido(plazo))
                    Console.WriteLine("- El plazo debe estar entre 2 y 7 años");
                if (!EsTipoValido(tipo))
                    Console.WriteLine("- El tipo de empleado debe ser P, R o I");
            }
        }

        // Método para validar salario
        static bool EsSalarioValido(double salario)
        {
            return salario > 0;
        }

        // Método para validar plazo
        static bool EsPlazoValido(int plazo)
        {
            return plazo >= 2 && plazo <= 7;
        }

        // Método para validar tipo de empleado
        static bool EsTipoValido(char tipo)
        {
            return tipo == 'P' || tipo == 'R' || tipo == 'I';
        }

        // Método para calcular el monto del préstamo
        static double CalcularMontoPrestamo(double salario, int plazo, char tipo)
        {
            switch (tipo)
            {
                case 'P': // Público
                    return salario * 2 * plazo;
                case 'R': // Privado
                    return salario * 1.5 * plazo;
                case 'I': // Independiente
                    return salario * 1 * plazo;
                default:
                    return 0; // No debería llegar aquí si se valida antes
            }
        }
    }
}
