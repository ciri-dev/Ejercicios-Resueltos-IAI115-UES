using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {       /*
             * 6- Dados la longitud de un cubo y el radio de una esfera, calcule e imprima la superficie 
             * y el volumen en unidades cuadradas y cúbicas respectivamente. También se pide que calcule 
             * e imprima cuál es el volumen total de ambas figuras tridimensionales. 
             */
        static void Main(string[] args)
        {   
            // Declaracion de variables
            double ladoCubo, superficieCubo, volumenCubo;
            double radioEsfera, superficieEsfera, volumenEsfera;
            double volumenTotal;

            // Entrada de datos
            Console.WriteLine("Ingrese la longitud del lado del cubo (en metros): ");
            ladoCubo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el radio de la esfera (en metros): ");
            radioEsfera = double.Parse(Console.ReadLine());

            // Proceso de datos
            superficieCubo = 6 * Math.Pow(ladoCubo, 2); 
            volumenCubo = Math.Pow(ladoCubo, 3); 

            superficieEsfera = 4 * Math.PI * Math.Pow(radioEsfera, 2); 
            volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);

            volumenTotal = volumenCubo + volumenEsfera;

            // Salida de datos
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Superficie del cubo: {superficieCubo:F2} m²");
            Console.WriteLine($"Volumen del cubo: {volumenCubo:F2} m³");
            Console.WriteLine($"Superficie de la esfera: {superficieEsfera:F2} m²");
            Console.WriteLine($"Volumen de la esfera: {volumenEsfera:F2} m³");
            Console.WriteLine($"Volumen total combinado: {volumenTotal:F2} m³");

            Console.ReadKey();
        }
    }
}
