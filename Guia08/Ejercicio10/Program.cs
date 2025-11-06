using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {   /*
         * 10- Diseñe una solución que permita ingresar la nota del primer parcial 
         * de IAI115, por grupo de teórico (asuma que son 3 grupos) la cantidad 
         * de alumnos por grupo varía o se desconoce. Diseñe una solución que 
         * imprima el promedio por grupo teórico.
         */
        static void Main(string[] args)
        {
            for (int grupo = 1; grupo <= 3; grupo++)
            {
                Console.WriteLine($"\n--- Grupo Teórico #{grupo} ---");
                double promedio = ProcesarGrupo();
                Console.WriteLine($"Promedio del Grupo #{grupo}: {promedio:0.00}");
            }
        }

        // Método para procesar un grupo teórico
        static double ProcesarGrupo()
        {
            int contador = 0;
            double suma = 0;
            string respuesta;

            do
            {
                double nota = LeerNota(contador + 1);
                suma += nota;
                contador++;

                Console.Write("¿Desea ingresar otra nota para este grupo? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            return (contador > 0) ? suma / contador : 0;
        }

        // Método para leer y validar una nota
        static double LeerNota(int indice)
        {
            double nota;
            do
            {
                Console.Write($"Ingrese la nota #{indice} (0 a 10): ");
                nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10)
                    Console.WriteLine("Nota inválida. Debe estar entre 0 y 10.");

            } while (nota < 0 || nota > 10);

            return nota;
        }
        
    }
}
