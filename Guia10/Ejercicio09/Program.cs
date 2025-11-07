using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{   /*
     * 9- La empresa “ProduceMucho” registra el consumo energético en que 
     * generan sus 4 plantas de producción en los primeros seis meses del año:
     * Según los datos dados se requiere saber: 
     * a)  Total de energía gastado por cada mes  
     * b)  Mes en el que se gastó más energía 
     * c)  Total de energía por cada planta de producción  
     * d)  Planta que consume menos energía 
     * e)  Promedio de consumo energético por planta  
     * f)  Promedio de consume energético por mes 
     * g)  Sabiendo que 1 MW hora cuesta $129.7 cuanto tiene que pagar la empresa en 
     * cada mes en concepto de pago de energía eléctrica 
     * h)  Sabiendo que el costo de energía eléctrica disminuirá en un 4%, y considerando 
     * que las tendencias de consumo permanecen exactamente iguales para el próximo 
     * semestre cual será el ahorro mensual que tendrá la empresa.
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio" };
            string[] plantas = { "Planta1", "Planta2", "Planta3" };

            float[,] consumo = {
                { 100, 220, 140, 300, 521, 120 },
                { 125, 140, 110, 175, 560, 320 },
                { 250, 220, 260, 236, 680, 400 }
            };

            float[] totalMes = CalcularTotalPorMes(consumo);
            float[] totalPlanta = CalcularTotalPorPlanta(consumo);
            float[] promedioPlanta = CalcularPromedioPorPlanta(totalPlanta);
            float[] promedioMes = CalcularPromedioPorMes(totalMes);
            float[] costoMes = CalcularCostoPorMes(totalMes, 129.7f);
            float[] ahorroMes = CalcularAhorroMensual(costoMes, 0.04f);

            Console.WriteLine("\n--- a) Total de energía por mes ---");
            for (int i = 0; i < meses.Length; i++)
                Console.WriteLine($"{meses[i]}: {totalMes[i]} MW");

            Console.WriteLine("\n--- b) Mes con mayor consumo ---");
            int mesMayor = ObtenerIndiceMayor(totalMes);
            Console.WriteLine($"{meses[mesMayor]} con {totalMes[mesMayor]} MW");

            Console.WriteLine("\n--- c) Total de energía por planta ---");
            for (int i = 0; i < plantas.Length; i++)
                Console.WriteLine($"{plantas[i]}: {totalPlanta[i]} MW");

            Console.WriteLine("\n--- d) Planta con menor consumo ---");
            int plantaMenor = ObtenerIndiceMenor(totalPlanta);
            Console.WriteLine($"{plantas[plantaMenor]} con {totalPlanta[plantaMenor]} MW");

            Console.WriteLine("\n--- e) Promedio de consumo por planta ---");
            for (int i = 0; i < plantas.Length; i++)
                Console.WriteLine($"{plantas[i]}: {promedioPlanta[i]:0.00} MW");

            Console.WriteLine("\n--- f) Promedio de consumo por mes ---");
            for (int i = 0; i < meses.Length; i++)
                Console.WriteLine($"{meses[i]}: {promedioMes[i]:0.00} MW");

            Console.WriteLine("\n--- g) Costo mensual de energía (a $129.7 por MW) ---");
            for (int i = 0; i < meses.Length; i++)
                Console.WriteLine($"{meses[i]}: ${costoMes[i]:0.00}");

            Console.WriteLine("\n--- h) Ahorro mensual con reducción del 4% ---");
            for (int i = 0; i < meses.Length; i++)
                Console.WriteLine($"{meses[i]}: ${ahorroMes[i]:0.00}");

            Console.ReadKey();
        }

        // Calcula el total de energía consumida por cada mes sumando los valores de todas las plantas
        static float[] CalcularTotalPorMes(float[,] matriz)
        {
            float[] total = new float[matriz.GetLength(1)];
            for (int j = 0; j < matriz.GetLength(1); j++)
                for (int i = 0; i < matriz.GetLength(0); i++)
                    total[j] += matriz[i, j];
            return total;
        }

        // Calcula el total de energía consumida por cada planta sumando sus valores mensuales
        static float[] CalcularTotalPorPlanta(float[,] matriz)
        {
            float[] total = new float[matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    total[i] += matriz[i, j];
            return total;
        }

        // Calcula el promedio mensual de consumo energético por planta dividiendo su total entre 6 meses
        static float[] CalcularPromedioPorPlanta(float[] totalPlanta)
        {
            float[] promedio = new float[totalPlanta.Length];
            for (int i = 0; i < totalPlanta.Length; i++)
                promedio[i] = totalPlanta[i] / 6f;
            return promedio;
        }

        // Calcula el promedio de consumo energético por mes dividiendo el total mensual entre 3 plantas
        static float[] CalcularPromedioPorMes(float[] totalMes)
        {
            float[] promedio = new float[totalMes.Length];
            for (int i = 0; i < totalMes.Length; i++)
                promedio[i] = totalMes[i] / 3f;
            return promedio;
        }

        // Calcula el costo mensual de energía multiplicando el total de consumo por la tarifa por MW
        static float[] CalcularCostoPorMes(float[] totalMes, float tarifa)
        {
            float[] costo = new float[totalMes.Length];
            for (int i = 0; i < totalMes.Length; i++)
                costo[i] = totalMes[i] * tarifa;
            return costo;
        }

        // Calcula el ahorro mensual aplicando un porcentaje de descuento sobre el costo original
        static float[] CalcularAhorroMensual(float[] costoMes, float descuento)
        {
            float[] ahorro = new float[costoMes.Length];
            for (int i = 0; i < costoMes.Length; i++)
                ahorro[i] = costoMes[i] * descuento;
            return ahorro;
        }

        // Devuelve el índice del elemento con mayor valor dentro de un vector
        static int ObtenerIndiceMayor(float[] vector)
        {
            int indice = 0;
            float mayor = vector[0];
            for (int i = 1; i < vector.Length; i++)
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                    indice = i;
                }
            return indice;
        }

        // Devuelve el índice del elemento con menor valor dentro de un vector
        static int ObtenerIndiceMenor(float[] vector)
        {
            int indice = 0;
            float menor = vector[0];
            for (int i = 1; i < vector.Length; i++)
                if (vector[i] < menor)
                {
                    menor = vector[i];
                    indice = i;
                }
            return indice;
        }
        
    }
}
