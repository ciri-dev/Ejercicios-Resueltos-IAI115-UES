using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {   /*
         * 1- Desarrollar un programa que presente el siguiente menú: 
         * Seno de x. 
         * Coseno de x. 
         * Tangente de x. 
         * Raiz cuadrada de x 
         * Potencia de Yx 
         * Verificar si un número es par o impar. 
         * Salir del Programa. 
         */
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear(); 

                switch (opcion)
                {
                    case 1:
                        CalcularSeno();
                        break;
                    case 2:
                        CalcularCoseno();
                        break;
                    case 3:
                        CalcularTangente();
                        break;
                    case 4:
                        CalcularRaizCuadrada();
                        break;
                    case 5:
                        CalcularPotencia();
                        break;
                    case 6:
                        VerificarParImpar();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (opcion != 7)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear(); // Limpia pantalla antes de volver al menú
                }

            } while (opcion != 7);
        }

        // Muestra el menú principal
        static void MostrarMenu()
        {
            Console.WriteLine("=== MENÚ MATEMÁTICO ===");
            Console.WriteLine("1. Seno de x");
            Console.WriteLine("2. Coseno de x");
            Console.WriteLine("3. Tangente de x");
            Console.WriteLine("4. Raíz cuadrada de x");
            Console.WriteLine("5. Potencia Y^x");
            Console.WriteLine("6. Verificar si un número es par o impar");
            Console.WriteLine("7. Salir del Programa");
            Console.WriteLine("========================");
        }

        // Calcula el seno de un número
        static void CalcularSeno()
        {
            Console.Write("Ingrese el valor de x (en radianes): ");
            double x = double.Parse(Console.ReadLine());
            double resultado = Math.Sin(x);
            Console.WriteLine($"El seno de {x} es: {resultado}");
        }

        // Calcula el coseno de un número
        static void CalcularCoseno()
        {
            Console.Write("Ingrese el valor de x (en radianes): ");
            double x = double.Parse(Console.ReadLine());
            double resultado = Math.Cos(x);
            Console.WriteLine($"El coseno de {x} es: {resultado}");
        }

        // Calcula la tangente de un número
        static void CalcularTangente()
        {
            Console.Write("Ingrese el valor de x (en radianes): ");
            double x = double.Parse(Console.ReadLine());
            double resultado = Math.Tan(x);
            Console.WriteLine($"La tangente de {x} es: {resultado}");
        }

        // Calcula la raíz cuadrada de un número
        static void CalcularRaizCuadrada()
        {
            Console.Write("Ingrese un número positivo: ");
            double x = double.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
            }
            else
            {
                double resultado = Math.Sqrt(x);
                Console.WriteLine($"La raíz cuadrada de {x} es: {resultado}");
            }
        }

        // Calcula la potencia Y^x
        static void CalcularPotencia()
        {
            Console.Write("Ingrese la base Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente x: ");
            double x = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(y, x);
            Console.WriteLine($"{y} elevado a la {x} es: {resultado}");
        }

        // Verifica si un número es par o impar
        static void VerificarParImpar()
        {
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} es un número par.");
            }
            else
            {
                Console.WriteLine($"{numero} es un número impar.");
            }
        }
    }
}
