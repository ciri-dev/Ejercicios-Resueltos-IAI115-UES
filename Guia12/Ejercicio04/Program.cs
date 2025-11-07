using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {   /*
         * 4- Haga un archivo con los siguientes números enteros: 
         * 20,15,17,64,12,47,36,45,26, cada uno debe estar en una línea del archivo 
         * (en lista) y sin la coma.  Elabore un programa que permita leer los 
         * números del archivo creado y asignarlos a una matriz de 3 por 3 de 
         * enteros. Imprima la matriz
         */
        static void Main(string[] args)
        {
            
            string ruta = "Numeros.txt"; 
            int[,] matriz = new int[3, 3];

            if (LeerArchivoEnMatriz(ruta, matriz))
            {
                Console.WriteLine("\nMatriz cargada desde archivo:");
                MostrarMatriz(matriz);
            }
            else
            {
                Console.WriteLine("Error al leer el archivo o cantidad incorrecta de datos.");
            }

            Console.ReadKey();
        }

        // Lee los números desde archivo y los asigna a la matriz
        static bool LeerArchivoEnMatriz(string ruta, int[,] matriz)
        {
            if (!File.Exists(ruta)) return false;

            using (StreamReader sr = new StreamReader(ruta))
            {
                int fila = 0, columna = 0;
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (int.TryParse(linea.Trim(), out int numero))
                    {
                        matriz[fila, columna] = numero;
                        columna++;
                        if (columna == 3)
                        {
                            columna = 0;
                            fila++;
                        }
                        if (fila == 3) break; 
                    }
                }
                return fila == 3; 
            }
        }

        // Muestra la matriz en consola
        static void MostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matriz[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        
    }
}
