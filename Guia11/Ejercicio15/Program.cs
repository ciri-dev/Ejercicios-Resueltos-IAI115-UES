using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{   /*
     * 15- El zoológico “el garrobito” desea guardar los datos de los pandas que 
     * viven en el zoológico.  La información que se desea guardar es la siguiente: 
     * nombre, peso, año y sexo. Además, se quiere determinar cuáles pandas están 
     * aptas para tener bebés, sabiendo que para poder tener bebés debe ser mayor 
     * que 5 años y (obvio) ser hembra. 
     * Realizar una solución que realice lo anterior, para los 15 pandas que viven 
     * en él zoológico. 
     */
    internal class Program
    {
        // Estructura para representar un panda
        public struct Panda
        {
            public string nombre;
            public double peso;
            public int edad;
            public char sexo;
        }

        static void Main(string[] args)
        {
            
            Panda[] pandas = new Panda[15];
            LeerPandas(pandas);

            Console.WriteLine("\nPandas aptas para tener bebés:");
            MostrarPandasAptas(pandas);

            Console.ReadKey();
        }

        // Lee los datos de los pandas
        static void LeerPandas(Panda[] pandas)
        {
            for (int i = 0; i < pandas.Length; i++)
            {
                Console.WriteLine($"\nPanda {i + 1}:");

                Console.Write("Nombre: ");
                pandas[i].nombre = Console.ReadLine();

                Console.Write("Peso (kg): ");
                while (!double.TryParse(Console.ReadLine(), out pandas[i].peso) || pandas[i].peso <= 0)
                    Console.WriteLine("Ingrese un peso válido.");

                Console.Write("Edad (años): ");
                while (!int.TryParse(Console.ReadLine(), out pandas[i].edad) || pandas[i].edad < 0)
                    Console.WriteLine("Ingrese una edad válida.");

                Console.Write("Sexo (M/F): ");
                pandas[i].sexo = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }
        }

        // Muestra pandas aptas para tener bebés
        static void MostrarPandasAptas(Panda[] pandas)
        {
            foreach (var panda in pandas)
            {
                if (panda.sexo == 'F' && panda.edad > 5)
                {
                    Console.WriteLine($"- {panda.nombre} | Edad: {panda.edad} años | Peso: {panda.peso} kg");
                }
            }
        }
        
    }
}
