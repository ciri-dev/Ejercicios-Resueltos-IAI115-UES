using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{   /*
     * 13- ANDA regula/verifica el nivel de plomo en agua de las envasadoras 
     * comerciales de agua de bebida. Para lo cual realiza varias visitas no 
     * anunciadas durante el mes a cada envasadora y en cada visita toma varias 
     * muestras. Diseñe una solución que de darse el caso imprima nombre de 
     * la envasadora y valor de la(s) muestra(s) que sobrepase(n) el nivel
     * máximo de plomo que es de 15 µg/L
     */
    internal class Program
    {
        const double LIMITE_PL = 15.0;

        static void Main(string[] args)
        {
            string respuesta;

            do
            {
                string nombre = LeerNombreEnvasadora();
                Console.Write("Ingrese la cantidad de visitas realizadas este mes: ");
                int visitas = int.Parse(Console.ReadLine());

                for (int v = 1; v <= visitas; v++)
                {
                    Console.Write($"\nVisita #{v}: ¿Cuántas muestras se tomaron? ");
                    int muestras = int.Parse(Console.ReadLine());

                    for (int m = 1; m <= muestras; m++)
                    {
                        double valor = LeerMuestra(nombre, v, m);
                        if (valor > LIMITE_PL)
                        {
                            Console.WriteLine($"Envasadora: {nombre} | Muestra #{m} en visita #{v} = {valor} µg/L → Excede el límite permitido.");
                        }
                    }
                }

                Console.Write("\n¿Desea ingresar otra envasadora? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");
        }

        // Método para leer el nombre de la envasadora
        static string LeerNombreEnvasadora()
        {
            Console.Write("\nIngrese el nombre de la envasadora: ");
            return Console.ReadLine();
        }

        // Método para leer y validar una muestra
        static double LeerMuestra(string nombre, int visita, int muestra)
        {
            double valor;
            do
            {
                Console.Write($"Ingrese el valor de la muestra #{muestra} en visita #{visita} para {nombre} (µg/L): ");
                valor = double.Parse(Console.ReadLine());

                if (valor < 0)
                    Console.WriteLine("El valor no puede ser negativo. Intente de nuevo.");

            } while (valor < 0);

            return valor;
        }
        
    }
}
