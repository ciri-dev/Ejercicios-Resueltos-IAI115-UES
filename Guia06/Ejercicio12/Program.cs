using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        /*
         * 12- Diseñe una solución que dado un ángulo en grados calcule y despliegue 
         * el seno, coseno y tangente para  ese  ángulo.  Considere  que  en  algunos  
         * casos  dichas  razones  trigonométricas  no  están definidas. Ejemplo: 
         * Tang(90) Nota: recordar que los lenguajes de programación trabajan en radianes. 
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            double angulo;
            double seno, coseno, tangente;
            double grados;

            // entrada de datos
            Console.Write("Ingrese el valor del angulo a calcular: ");
            angulo = double.Parse(Console.ReadLine());

            // proceso de datos
            grados = ConvertirAGrados(angulo);
            seno = CalcularSeno(grados);
            coseno = CalcularCoseno(grados);
            tangente = CalcularTangente(grados);

            // salida de datos
            Console.WriteLine("\nEl seno del angulo de {0} grados es: {1:F3}", angulo, seno);
            Console.WriteLine("El coseno del angulo de {0} grados es: {1:F3}", angulo, coseno);
            Console.WriteLine("La tangente del angulo de {0} grados es: {1:F3}", angulo, tangente);
            Console.ReadKey();
        }

        /// <summary>
        /// Convierte un ángulo de grados a radianes.
        /// </summary>
        static double ConvertirAGrados(double angulo)
        {
            double grados;
            grados = angulo * Math.PI / 180;
            return grados;
        }

        /// <summary>
        /// Calcula el seno de un ángulo dado en radianes.
        /// </summary>
        static double CalcularSeno(double angulo)
        {
            double seno;
            seno = Math.Sin(angulo);
            return seno;
        }

        /// <summary>
        /// Calcula el coseno de un ángulo dado en radianes.
        /// </summary>
        static double CalcularCoseno(double angulo)
        {
            double coseno;
            coseno = Math.Cos(angulo);
            return coseno;
        }

        /// <summary>
        /// Calcula la tangente de un ángulo dado en radianes, 
        /// evitando valores indefinidos en 90° y 180°.
        /// </summary>
        public static double CalcularTangente(double angulo)
        {
            double tangente = 0;
            if (angulo != 90 && angulo != 180)
            {
                tangente = Math.Tan(angulo);
                return tangente;
            }
            return tangente;
        }
        
        
    }
}
