using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {   /*
         * 4- En un vector de 25 elementos, se desea buscar un dato que será 
         * leído. Diseñe un programa que imprima el mensaje: “VALOR ENCONTRADO”, 
         * si en efecto el valor buscado ya se encuentra entre los elementos, y 
         * la posición o subíndice donde se encontró la primera vez. 
         * Si el valor no se encuentra, se debe sustituir el valor menor por el 
         * buscado, imprimiendo el elemento que sale del vector y la posición que 
         * ocupaba.
         */
        static void Main(string[] args)
        {
            int[] datos = new int[25];

            Console.WriteLine("=== Registro de 25 números enteros ===");
            LeerVector(datos);

            Console.Write("\nIngrese el valor a buscar: ");
            int valorBuscado = LeerEntero();

            int posicion = BuscarValor(datos, valorBuscado);

            if (posicion != -1)
            {
                Console.WriteLine($"\nVALOR ENCONTRADO en la posición {posicion}.");
            }
            else
            {
                int posicionMenor = BuscarPosicionMenor(datos);
                int valorEliminado = datos[posicionMenor];
                datos[posicionMenor] = valorBuscado;

                Console.WriteLine($"\nVALOR NO ENCONTRADO.");
                Console.WriteLine($"Se ha reemplazado el valor menor ({valorEliminado}) en la posición {posicionMenor} por {valorBuscado}.");
            }
        }

        // Método para leer 25 números enteros
        static void LeerVector(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                arreglo[i] = LeerEntero();
            }
        }

        // Método para validar y leer un número entero
        static int LeerEntero()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. Ingrese un número entero: ");
            }
            return numero;
        }

        // Método para buscar el valor en el vector
        // Retorna la posición si lo encuentra, -1 si no
        static int BuscarValor(int[] arreglo, int valor)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor)
                    return i;
            }
            return -1;
        }

        // Método para encontrar la posición del valor menor en el vector
        static int BuscarPosicionMenor(int[] arreglo)
        {
            int menor = arreglo[0];
            int posicion = 0;

            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] < menor)
                {
                    menor = arreglo[i];
                    posicion = i;
                }
            }
            return posicion;
        }
        
    }
}
