using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {   /*
         * 4- Dado el carnet y una nota, desplegar “Aprobado” o “Reprobado” y la clasificación 
         * de la nota, de acuerdo a lo siguiente: Excelente es mayor a 9 pero menor o igual a 
         * 10, Muy Bueno es mayor a 8 pero menor o igual a 9, Bueno es mayor a 7 pero menor o 
         * igual a 8,  Regular es mayor a 6 pero menor o igual a 7,  Malo es mayor a 4 pero 
         * menor o igual a 6, Muy Malo es mayor a 2 pero menor o igual a 4 y, por último, 
         * Necesita Mejorar es mayor o igual a 0 pero menor o igual a 2.
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            string carnet, estado, clasificacion;
            double nota;

            // entrada de datos
            Console.Write("Ingrese el carnet del estudiante: ");
            carnet = Console.ReadLine();

            Console.Write("Ingrese la nota (0 a 10): ");
            nota = double.Parse(Console.ReadLine());

            // Validación de nota
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Error: La nota debe estar entre 0 y 10.");
                return;
            }

            // proceso de datos
            estado = EsAprobado(nota) ? "Aprobado" : "Reprobado";
            clasificacion = ClasificarNota(nota);

            // salida de datos
            Console.WriteLine($"\nCarnet: {carnet}");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine($"Clasificación: {clasificacion}");
        }

        // Determina si la nota es aprobada
        static bool EsAprobado(double nota)
        {
            return nota >= 6;
        }

        // Clasifica la nota según los rangos definidos
        static string ClasificarNota(double nota)
        {
            if (nota > 9 && nota <= 10)
                return "Excelente";
            else if (nota > 8 && nota <= 9)
                return "Muy Bueno";
            else if (nota > 7 && nota <= 8)
                return "Bueno";
            else if (nota > 6 && nota <= 7)
                return "Regular";
            else if (nota > 4 && nota <= 6)
                return "Malo";
            else if (nota > 2 && nota <= 4)
                return "Muy Malo";
            else // nota entre 0 y 2
                return "Necesita Mejorar";
        }
    }
}
