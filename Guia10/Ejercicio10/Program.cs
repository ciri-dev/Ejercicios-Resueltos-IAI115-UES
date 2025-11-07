using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {   /*
         * 10- Se requiere un programa para hacer reserva de viviendas que presente 
         * una matriz indicando la ubicación de las casas asignando un 0 a las casas 
         * vacías y una 1 a las que se van reservando. Las casas reservadas deben irse 
         * colocando en color rojo. El programa debe funcionar para cualquier cantidad 
         * de clientes que quieran reservar su casa y después de cada reserva debe 
         * presentar la matriz actualizada, cantidad de casas disponibles y cantidad de 
         * casas reservadas. 
         * Elabore un método que permita ampliar el número de viviendas construídas.
         */
        static void Main(string[] args)
        {

            int filas = 4, columnas = 4;
            int[,] viviendas = new int[filas, columnas];

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- Menú de opciones ---");
                Console.WriteLine("1. Mostrar matriz de viviendas");
                Console.WriteLine("2. Reservar una vivienda");
                Console.WriteLine("3. Mostrar estadísticas");
                Console.WriteLine("4. Ampliar complejo residencial");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarMatriz(viviendas);
                        break;
                    case "2":
                        ReservarVivienda(viviendas);
                        break;
                    case "3":
                        MostrarEstadisticas(viviendas);
                        break;
                    case "4":
                        viviendas = AmpliarComplejo(viviendas);
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        // Muestra la matriz actual de viviendas
        static void MostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("\nEstado actual del complejo:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        // Permite reservar una vivienda si está disponible
        static void ReservarVivienda(int[,] matriz)
        {
            Console.Write("Ingrese fila (1 a " + matriz.GetLength(0) + "): ");
            int fila = LeerIndice(matriz.GetLength(0));
            Console.Write("Ingrese columna (1 a " + matriz.GetLength(1) + "): ");
            int columna = LeerIndice(matriz.GetLength(1));

            if (matriz[fila, columna] == 0)
            {
                matriz[fila, columna] = 1;
                Console.WriteLine("Vivienda reservada exitosamente.");
                MostrarMatriz(matriz);
            }
            else
            {
                Console.WriteLine("Esa vivienda ya está reservada.");
            }
        }

        // Lee y valida un índice dentro del rango
        static int LeerIndice(int limite)
        {
            int valor;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out valor) || valor < 1 || valor > limite)
                {
                    Console.WriteLine($"Ingrese un número entre 1 y {limite}.");
                }
            } while (valor < 1 || valor > limite);
            return valor - 1; // Ajuste a índice base 0
        }

        // Muestra estadísticas de reservas
        static void MostrarEstadisticas(int[,] matriz)
        {
            int disponibles = 0, reservadas = 0;
            foreach (int casa in matriz)
            {
                if (casa == 0) disponibles++;
                else reservadas++;
            }
            Console.WriteLine($"\nCasas disponibles: {disponibles}");
            Console.WriteLine($"Casas reservadas: {reservadas}");
        }

        // Permite ampliar el complejo residencial
        static int[,] AmpliarComplejo(int[,] matriz)
        {
            Console.Write("Ingrese nuevas filas totales: ");
            int nuevasFilas = LeerTamaño(matriz.GetLength(0));
            Console.Write("Ingrese nuevas columnas totales: ");
            int nuevasColumnas = LeerTamaño(matriz.GetLength(1));

            int[,] nuevaMatriz = new int[nuevasFilas, nuevasColumnas];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    nuevaMatriz[i, j] = matriz[i, j];
                }
            }

            Console.WriteLine("Complejo ampliado exitosamente.");
            return nuevaMatriz;
        }

        // Valida que el nuevo tamaño sea mayor al actual
        static int LeerTamaño(int actual)
        {
            int valor;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out valor) || valor <= actual)
                {
                    Console.WriteLine($"Ingrese un número mayor a {actual}.");
                }
            } while (valor <= actual);
            return valor;
        }
        
    }
}
