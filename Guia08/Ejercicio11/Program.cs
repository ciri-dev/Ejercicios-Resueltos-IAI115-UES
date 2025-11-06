using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio11
{
    internal class Program
    {   /*
         * 11- Fábrica de Baterías “Trueno” realiza exámenes de plomo en sangre 
         * a sus empleados.  Se toman 3 muestras a fin de mes. Diseñe una 
         * solución que para cada empleado lea nombre y los 3 resultados en  
         * µg/dL. De encontrarse un trabajador con niveles de plomo en sangre 
         * mayores a 40, imprima nombre, resultado en  µg/dL y el mensaje: 
         * pasar a revisión médica.
         */
        static void Main(string[] args)
        {
            string respuesta;

            do
            {
                string nombre = LeerNombre();
                bool requiereRevision = false;

                for (int i = 1; i <= 3; i++)
                {
                    double muestra = LeerMuestra(i);

                    if (muestra > 40)
                    {
                        Console.WriteLine($"\n{nombre} tiene una muestra de {muestra} µg/dL.");
                        Console.WriteLine("→ Pasar a revisión médica.");
                        requiereRevision = true;
                    }
                }

                if (!requiereRevision)
                {
                    Console.WriteLine($"\n{nombre} no presenta niveles críticos en ninguna muestra.");
                }

                Console.Write("\n¿Desea ingresar otro empleado? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            Console.WriteLine("\nProceso finalizado.");
        }

        // Método para leer el nombre del empleado
        static string LeerNombre()
        {
            Console.Write("\nIngrese el nombre del empleado: ");
            return Console.ReadLine();
        }

        // Método para leer y validar una muestra
        static double LeerMuestra(int indice)
        {
            double valor;
            do
            {
                Console.Write($"Ingrese la muestra #{indice} en µg/dL: ");
                valor = double.Parse(Console.ReadLine());

                if (valor < 0)
                    Console.WriteLine("La muestra no puede ser negativa. Intente de nuevo.");

            } while (valor < 0);

            return valor;
        }
        
    }
}
