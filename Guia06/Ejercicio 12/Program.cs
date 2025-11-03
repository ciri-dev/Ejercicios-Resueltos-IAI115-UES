using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {   /*
         * 12- Diseñe una solución que dado un ángulo en grados calcule y despliegue 
         * el seno, coseno y tangente para  ese  ángulo.  Considere  que  en  algunos  
         * casos  dichas  razones  trigonométricas  no  están definidas. 
         * Ejemplo: Tang(90) Nota: recordar que los lenguajes de programación trabajan 
         * en radianes.
         */
        static void Main(string[] args)
        {   
            // declaracion de variables 
            double grados, radianes;
            double seno, coseno;

            // entrada de datos
            grados = LeerAngulo("Ingrese el ángulo en grados:");
            radianes = ConvertirARadianes(grados);

            // proceso de datos
            seno = Math.Sin(radianes);
            coseno = Math.Cos(radianes);

            // Verificar si tangente está definida
            string tangenteTexto;
            if (Math.Abs(coseno) < 1e-10) // coseno ≈ 0
            {
                tangenteTexto = "No definida";
            }
            else
            {
                double tangente = Math.Tan(radianes);
                tangenteTexto = $"{tangente:0.000}";
            }

            // salida de datos
            MostrarResultados(grados, seno, coseno, tangenteTexto);
        }

        static double LeerAngulo(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        static double ConvertirARadianes(double grados)
        {
            return grados * Math.PI / 180;
        }

        static void MostrarResultados(double grados, double seno, double coseno, string tangente)
        {
            Console.WriteLine($"\nÁngulo: {grados}°");
            Console.WriteLine($"Seno: {seno:0.000}");
            Console.WriteLine($"Coseno: {coseno:0.000}");
            Console.WriteLine($"Tangente: {tangente}");
        }
    }
}
