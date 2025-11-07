using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {   /*
         * 3- Elabore un programa que permita leer desde un archivo el listado de 
         * participantes de un concurso, los guarde e imprima en consola.
         */
        static void Main(string[] args)
        {
            
            string ruta = "Participantes.txt"; // Asegúrate de que este archivo exista
            List<string> participantes = LeerParticipantesDesdeArchivo(ruta);

            Console.WriteLine($"\nParticipantes del concurso ({participantes.Count}):");
            MostrarParticipantes(participantes);

            Console.ReadKey();
        }

        // Lee los nombres de participantes desde un archivo
        static List<string> LeerParticipantesDesdeArchivo(string ruta)
        {
            List<string> lista = new List<string>();
            if (File.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(linea))
                            lista.Add(linea.Trim());
                    }
                }
            }
            else
            {
                Console.WriteLine($"El archivo '{ruta}' no existe.");
            }
            return lista;
        }

        // Muestra los participantes en consola
        static void MostrarParticipantes(List<string> participantes)
        {
            foreach (string nombre in participantes)
            {
                Console.WriteLine($"- {nombre}");
            }
        }
        
    }
}
