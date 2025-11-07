using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {   /*
         * 8- Se necesita conocer la frecuencia de cada uno de los elementos de 
         * un vector de n elementos
         */
        static void Main(string[] args)
        {
            int[] vec = { 6, 7, 5, 4, 5, 3, 6, 7, 2, 6 };
            int[] vec1 = new int[vec.Length];
            int[] frecuencia = new int[vec.Length];
            int contadorUnicos = 0;

            Console.WriteLine("=== Vector original ===");
            ImprimirVector("vec", vec);

            // Construir vec1 y frecuencia
            for (int i = 0; i < vec.Length; i++)
            {
                if (!ExisteEnVector(vec1, contadorUnicos, vec[i]))
                {
                    vec1[contadorUnicos] = vec[i];
                    frecuencia[contadorUnicos] = ContarFrecuencia(vec, vec[i]);
                    contadorUnicos++;
                }
            }

            // Redimensionar vec1 y frecuencia para imprimir solo los elementos válidos
            int[] vec1Final = new int[contadorUnicos];
            int[] frecuenciaFinal = new int[contadorUnicos];
            Array.Copy(vec1, vec1Final, contadorUnicos);
            Array.Copy(frecuencia, frecuenciaFinal, contadorUnicos);

            Console.WriteLine("\n=== Elementos únicos (Vec1) ===");
            ImprimirVector("Vec1", vec1Final);

            Console.WriteLine("\n=== Frecuencia de cada elemento ===");
            ImprimirVector("Frecuencia", frecuenciaFinal);
        }

        // Verifica si un valor ya existe en el vector vec1
        static bool ExisteEnVector(int[] arreglo, int limite, int valor)
        {
            for (int i = 0; i < limite; i++)
            {
                if (arreglo[i] == valor)
                    return true;
            }
            return false;
        }

        // Cuenta cuántas veces aparece un valor en el vector original
        static int ContarFrecuencia(int[] arreglo, int valor)
        {
            int contador = 0;
            foreach (int elemento in arreglo)
            {
                if (elemento == valor)
                    contador++;
            }
            return contador;
        }

        // Imprime un vector con su nombre
        static void ImprimirVector(string nombre, int[] arreglo)
        {
            Console.Write($"{nombre}: ");
            foreach (int elemento in arreglo)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
        }
        
    }
}
