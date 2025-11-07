using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{   /*
     * 13- Crea una "estructura" para almacenar datos de puntos 2D. Los campos 
     * para cada punto serán: coordenada x, coordenada y. Realice una solucion 
     * que cree dos "puntos", solicite al usuario sus datos y luego muestre su contenido.
     */
    internal class Program
    {
        // Definición de la estructura Punto
        public struct Punto
        {
            public double x;
            public double y;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese los datos del primer punto:");
            Punto punto1 = LeerPunto();

            Console.WriteLine("\nIngrese los datos del segundo punto:");
            Punto punto2 = LeerPunto();

            Console.WriteLine("\nPuntos ingresados:");
            MostrarPunto(punto1, "Punto 1");
            MostrarPunto(punto2, "Punto 2");

            Console.ReadKey();
        }

        // Solicita las coordenadas de un punto
        static Punto LeerPunto()
        {
            Punto p;
            p.x = LeerCoordenada("x");
            p.y = LeerCoordenada("y");
            return p;
        }

        // Lee una coordenada con validación
        static double LeerCoordenada(string nombre)
        {
            double valor;
            do
            {
                Console.Write($"Ingrese la coordenada {nombre}: ");
            } while (!double.TryParse(Console.ReadLine(), out valor));
            return valor;
        }

        // Muestra el contenido de un punto
        static void MostrarPunto(Punto p, string etiqueta)
        {
            Console.WriteLine($"{etiqueta}: ({p.x}, {p.y})");
        }
        
    }
}
