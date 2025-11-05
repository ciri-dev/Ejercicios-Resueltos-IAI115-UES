using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        /*
         * 7- Dadas la talla de cintura de una persona y la distancia de la cintura al tobillo en
         * centímetros, despliegue si su talla es S, M ó L y la cantidad de tela, en yardas, necesaria para
         * hacer un pantalón. Tomar en cuenta que: S (menor a 60 cm), M (de 60 a  80cm), L (mayor que
         * 80cm). La cantidad de tela a utilizar, viene dada por la relación: ((cintura+altura)/2) * 2.5 / 91.44
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            int cintura, altura;
            string talla;
            float tela;

            // entrada de datos
            cintura = LeerEntero("Ingrese la medida de cintura (cm): ");
            altura = LeerEntero("Ingrese la distancia de cintura al tobillo (cm): ");

            // proceso de datos
            talla = CalcularTalla(cintura);
            tela = CalcularTela(cintura, altura);

            // salida de datos
            MostrarResultado(talla, tela);
        }

        // Solicita al usuario un número entero
        static int LeerEntero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }

        // Determina la talla de la persona según la medida de cintura.
        static string CalcularTalla(int cintura)
        {
            if (cintura < 60)
                return "S";
            else if (cintura <= 80)
                return "M";
            else
                return "L";
        }

        // Calcula la cantidad de tela necesaria en yardas para hacer un pantalón.
        static float CalcularTela(int cintura, int altura)
        {
            return ((cintura + altura) / 2f) * 2.5f / 91.44f;
        }

        // Muestra en pantalla la talla y la cantidad de tela necesaria.
        static void MostrarResultado(string talla, float tela)
        {
            Console.WriteLine($"\nTalla: {talla}");
            Console.WriteLine($"Cantidad de tela necesaria: {tela:0.00} yardas");
        }
    }
}
