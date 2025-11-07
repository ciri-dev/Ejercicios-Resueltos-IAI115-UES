using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {   /*
         * 9- Diseñar un programa que lea el nombre completo de una persona 
         * (dos nombres y dos apellidos) y despliegue solamente el primer apellido.
         */
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el nombre completo (dos nombres y dos apellidos): ");
            string nombreCompleto = LeerNombreCompleto();

            string primerApellido = ExtraerPrimerApellido(nombreCompleto);
            Console.WriteLine($"\nPrimer apellido: {primerApellido}");

            Console.ReadKey();
        }

        // Lee una cadena no vacía y valida que tenga al menos cuatro palabras
        static string LeerNombreCompleto()
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                string[] partes = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                if (partes.Length < 4)
                    Console.WriteLine("Ingrese al menos dos nombres y dos apellidos.");
                else
                    return texto;
            } while (true);
        }

        // Extrae el primer apellido (tercer palabra) de la cadena
        static string ExtraerPrimerApellido(string nombreCompleto)
        {
            string[] partes = nombreCompleto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return partes[2]; 
        }
        
    }
}
