using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{   /*
     * 5- Dada la cantidad de semanas de clase en la Universidad, cursadas por un estudiante 
     * egresado, despliegue la cantidad de años y ciclos clase del mencionado estudiante. Si 
     * la cantidad de años es mayor a 5, desplegar “Retraso”, dado que las carreras duran 5 
     * años. Las medidas a considerar son: 1 mes clase = 4 semanas clase, 1 ciclo clase = 4 
     * meses clase, 1 año clase = 8 meses clase = 2 ciclos clase.
     */
    internal class Program
    {
        // Constantes de conversión
        const int SEMANAS_POR_MES = 4;
        const int MESES_POR_CICLO = 4;
        const int MESES_POR_ANIO = 8;
        const int SEMANAS_POR_CICLO = SEMANAS_POR_MES * MESES_POR_CICLO; // 16
        const int SEMANAS_POR_ANIO = SEMANAS_POR_MES * MESES_POR_ANIO;   // 32

        static void Main(string[] args)
        {   
            // declaracion de variables
            int semanas, anios, semanasRestantes, ciclosTotales;

            // entrada de datos
            Console.Write("Ingrese la cantidad de semanas cursadas: ");
            semanas = int.Parse(Console.ReadLine());

            // Validación
            if (semanas < 0)
            {
                Console.WriteLine("Error: La cantidad de semanas debe ser positiva.");
                return;
            }

            // proceso de datos
            anios = CalcularAnios(semanas);
            ciclosTotales = CalcularCiclos(semanas);

            // salida de datos
            Console.WriteLine($"\nSemanas cursadas: {semanas}");
            Console.WriteLine($"Años clase: {anios}");
            Console.WriteLine($"Ciclos clase totales: {ciclosTotales}");

            // Evaluar retraso
            if (anios > 5)
            {
                Console.WriteLine("Estado: Retraso");
            }
        }

        // Calcula la cantidad de años clase
        static int CalcularAnios(int semanas)
        {
            return semanas / SEMANAS_POR_ANIO;
        }

        // Calcula ciclos clase a partir de las semanas
        static int CalcularCiclos(int semanas)
        {
            return semanas / SEMANAS_POR_CICLO;
        }
    }
}
