using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Program
    {   /*
         * 16- Dado que la cantidad de grupos teóricos es diferente y la cantidad 
         * de alumnos examinados por grupo teórico también, diseñe una solución 
         * que permita ingresar por grupo teórico la nota de cada estudiante e 
         * imprima la nota promedio de cada grupo.
         */
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de grupos teóricos: ");
            int cantidadGrupos = int.Parse(Console.ReadLine());

            for (int grupo = 1; grupo <= cantidadGrupos; grupo++)
            {
                Console.WriteLine($"\n--- Grupo Teórico #{grupo} ---");
                double promedio = ProcesarGrupo(grupo);
                Console.WriteLine($"\nPromedio del Grupo #{grupo}: {promedio:0.00}");
            }
        }

        // Método para procesar las notas de un grupo
        static double ProcesarGrupo(int grupo)
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
