using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{   /*
     * 10- Utilizando vectores resuelva el siguiente problema 
        Teniendo el registro de los equipos de fútbol de la liga española en 
        un vector y la cantidad de goles obtenidos por cada uno en el último 
        torneo en otro vector. Determine los siguiente datos: 
        Cual fue el equipo más goleador 
        Cual fue el equipo con menos goles 
        Cuantos goles en promedio obtuvo cada equipo 
        Cuantos goles se dieron en el torneo 
        Cuales equipos están abajo del promedio de goles 
        Cuales equipos obtuvieron más del promedio de goles.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] equipos = new string[]
            {
                "Real Madrid", "Barcelona", "Girona", "Atlético de Madrid", "Athletic Club",
                "Real Sociedad", "Valencia", "Villarreal", "Betis", "Osasuna",
                "Getafe", "Sevilla", "Celta de Vigo", "Rayo Vallecano", "Las Palmas",
                "Alavés", "Mallorca", "Cádiz", "Granada", "Almería"
            };

            int[] goles = new int[]
            {
                87, 79, 85, 70, 60,
                55, 50, 65, 52, 47,
                45, 42, 43, 40, 38,
                36, 34, 30, 28, 25
            };

            int totalGoles = CalcularTotal(goles);
            double promedio = CalcularPromedio(goles);
            int indiceMax = BuscarIndiceMaximo(goles);
            int indiceMin = BuscarIndiceMinimo(goles);

            Console.WriteLine($"\nEquipo más goleador: {equipos[indiceMax]} con {goles[indiceMax]} goles.");
            Console.WriteLine($"Equipo con menos goles: {equipos[indiceMin]} con {goles[indiceMin]} goles.");
            Console.WriteLine($"Total de goles en el torneo: {totalGoles}");
            Console.WriteLine($"Promedio de goles por equipo: {promedio:F2}");

            Console.WriteLine("\nEquipos por debajo del promedio:");
            ListarEquiposPorCondicion(equipos, goles, promedio, menor: true);

            Console.WriteLine("\nEquipos por encima del promedio:");
            ListarEquiposPorCondicion(equipos, goles, promedio, menor: false);
        }

        // Método para calcular el total de goles
        static int CalcularTotal(int[] arreglo)
        {
            int suma = 0;
            foreach (int valor in arreglo)
            {
                suma += valor;
            }
            return suma;
        }

        // Método para calcular el promedio de goles
        static double CalcularPromedio(int[] arreglo)
        {
            return (double)CalcularTotal(arreglo) / arreglo.Length;
        }

        // Método para encontrar el índice del equipo con más goles
        static int BuscarIndiceMaximo(int[] arreglo)
        {
            int max = arreglo[0];
            int indice = 0;
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] > max)
                {
                    max = arreglo[i];
                    indice = i;
                }
            }
            return indice;
        }

        // Método para encontrar el índice del equipo con menos goles
        static int BuscarIndiceMinimo(int[] arreglo)
        {
            int min = arreglo[0];
            int indice = 0;
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] < min)
                {
                    min = arreglo[i];
                    indice = i;
                }
            }
            return indice;
        }

        // Método para listar equipos por encima o debajo del promedio
        static void ListarEquiposPorCondicion(string[] nombres, int[] goles, double promedio, bool menor)
        {
            for (int i = 0; i < goles.Length; i++)
            {
                if ((menor && goles[i] < promedio) || (!menor && goles[i] > promedio))
                {
                    Console.WriteLine($"- {nombres[i]}: {goles[i]} goles");
                }
            }
        }
        
    }
}
