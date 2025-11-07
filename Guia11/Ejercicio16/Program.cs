using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{   /*
     * 16- Cree una calculadora de fracciones, las operaciones disponibles en 
     * esta calculadora serán, sumar, restar, multiplicar y dividir 2 fracciones, 
     * además debe mostrar el resultado de la operación seleccionada por el 
     * usuario por pantalla (sugerencia: utilice una estructura de selección multiple).
     */
    internal class Program
    {
        // Estructura para representar una fracción
        public struct Fraccion
        {
            public int numerador;
            public int denominador;
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese la primera fracción:");
            Fraccion f1 = LeerFraccion();

            Console.WriteLine("\nIngrese la segunda fracción:");
            Fraccion f2 = LeerFraccion();

            Console.WriteLine("\nSeleccione la operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            Fraccion resultado;

            switch (opcion)
            {
                case "1":
                    resultado = Sumar(f1, f2);
                    Console.WriteLine($"\nResultado: {resultado.numerador}/{resultado.denominador}");
                    break;
                case "2":
                    resultado = Restar(f1, f2);
                    Console.WriteLine($"\nResultado: {resultado.numerador}/{resultado.denominador}");
                    break;
                case "3":
                    resultado = Multiplicar(f1, f2);
                    Console.WriteLine($"\nResultado: {resultado.numerador}/{resultado.denominador}");
                    break;
                case "4":
                    if (f2.numerador == 0)
                        Console.WriteLine("No se puede dividir por una fracción con numerador cero.");
                    else
                    {
                        resultado = Dividir(f1, f2);
                        Console.WriteLine($"\nResultado: {resultado.numerador}/{resultado.denominador}");
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.ReadKey();
        }

        // Lee una fracción desde consola
        static Fraccion LeerFraccion()
        {
            Fraccion f;
            Console.Write("Numerador: ");
            while (!int.TryParse(Console.ReadLine(), out f.numerador)) Console.Write("Ingrese un número válido: ");

            Console.Write("Denominador: ");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out f.denominador) || f.denominador == 0)
                    Console.Write("El denominador no puede ser cero. Intente de nuevo: ");
            } while (f.denominador == 0);
            return f;
        }

        // Operaciones básicas
        static Fraccion Sumar(Fraccion a, Fraccion b)
        {
            return new Fraccion
            {
                numerador = a.numerador * b.denominador + b.numerador * a.denominador,
                denominador = a.denominador * b.denominador
            };
        }

        static Fraccion Restar(Fraccion a, Fraccion b)
        {
            return new Fraccion
            {
                numerador = a.numerador * b.denominador - b.numerador * a.denominador,
                denominador = a.denominador * b.denominador
            };
        }

        static Fraccion Multiplicar(Fraccion a, Fraccion b)
        {
            return new Fraccion
            {
                numerador = a.numerador * b.numerador,
                denominador = a.denominador * b.denominador
            };
        }

        static Fraccion Dividir(Fraccion a, Fraccion b)
        {
            return new Fraccion
            {
                numerador = a.numerador * b.denominador,
                denominador = a.denominador * b.numerador
            };
        }
        
    }
}
