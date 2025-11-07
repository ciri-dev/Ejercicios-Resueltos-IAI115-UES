using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {   /*
         * 1- Elabore un programa que genere un archivo con el nombre de 10 
         * empleados de una empresa (debe leer los nombres del teclado) 
         */
        static void Main(string[] args)
        {
            
            string[] empleados = new string[10];
            LeerNombres(empleados);

            string ruta = "Empleados.txt";
            GuardarEnArchivo(empleados, ruta);

            Console.WriteLine($"\nArchivo generado exitosamente: {ruta}");
            // Para conocer la ruta donde queda guardado
            // Console.WriteLine($"Ruta completa: {Path.GetFullPath("Empleados.txt")}");
            Console.ReadKey();
        }

        // Lee los nombres de los empleados desde teclado
        static void LeerNombres(string[] empleados)
        {
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.Write($"Ingrese el nombre del empleado {i + 1}: ");
                string nombre;
                do
                {
                    nombre = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nombre))
                        Console.WriteLine("El nombre no puede estar vacío.");
                } while (string.IsNullOrWhiteSpace(nombre));
                empleados[i] = nombre;
            }
        }

        // Guarda los nombres en un archivo de texto
        static void GuardarEnArchivo(string[] empleados, string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                foreach (string nombre in empleados)
                {
                    sw.WriteLine(nombre);
                }
            }
        }
        
    }
}
