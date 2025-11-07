using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {   /*
         * 2- Elabore un programa que lea números enteros de un dígito desde un 
         * archivo  y los almacene en un vector, mostrando el vector resultante.  
         * Considere un vector de máximo 100 elementos.
         */
        static void Main(string[] args)
        {
           
            string ruta = "Numeros.txt"; // Asegúrate de que este archivo exista y modifica la ruta
            int[] vector = new int[100];
            int cantidad = LeerNumerosDesdeArchivo(ruta, vector);

            Console.WriteLine($"\nVector resultante con {cantidad} elementos:");
            MostrarVector(vector, cantidad);

            Console.ReadKey();
        }

        // Lee números enteros de un dígito desde archivo y los almacena en el vector
        static int LeerNumerosDesdeArchivo(string ruta, int[] vector)
        {
            int contador = 0;
            if (File.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null && contador < vector.Length)
                    {
                        if (int.TryParse(linea, out int numero) && numero >= 0 && numero <= 9)
                        {
                            vector[contador++] = numero;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"El archivo '{ruta}' no existe.");
            }
            return contador;
        }

        // Muestra los elementos del vector
        static void MostrarVector(int[] vector, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
        }
        
    }
}
