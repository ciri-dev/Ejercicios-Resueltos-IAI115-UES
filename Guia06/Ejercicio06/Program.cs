using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{   /* 
     * 6- Diseñe una solución que dado un valor en Bytes, lo imprima en términos de Gigabytes, 
     Megabytes y Kilobytes. Ejemplo de impresiones: 1 Gb 3 Mb 2 Kb, pero sí la cantidad resulta 
     ser cero no debe imprimirse. Ejemplo: 3 Mb 100 Kb (la cantidad de Gb es cero)
     */
    internal class Program
    {   
        // constantes de conversión
        const long BYTES_KB = 1024;
        const long BYTES_MB = BYTES_KB * 1024;
        const long BYTES_GB = BYTES_MB * 1024;
        static void Main(string[] args)
        {      
            // entrada de datos
            long bytes = LeerEntero("Ingrese la cantidad en Bytes:");

            // Validación
            if (bytes <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
                return;
            }

            // proceso de datos
            long gb = CalcularGB(bytes);
            long mb = CalcularMB(bytes);
            long kb = CalcularKB(bytes);

            // salida de datos
            MostrarResultado(gb, mb, kb);
        }

        // Método para leer y validar entrada
        static long LeerEntero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return long.Parse(Console.ReadLine());
        }

        // Métodos de conversión
        static long CalcularGB(long bytes)
        {
            return bytes / BYTES_GB;
        }

        static long CalcularMB(long bytes)
        {
            long restoGb = bytes % BYTES_GB;
            return restoGb / BYTES_MB;
        }

        static long CalcularKB(long bytes)
        {
            long restoGb = bytes % BYTES_GB;
            long restoMb = restoGb % BYTES_MB;
            return restoMb / BYTES_KB;
        }

        // Método para mostrar resultados
        static void MostrarResultado(long gb, long mb, long kb)
        {
            if (gb > 0) Console.Write($"{gb}Gb ");
            if (mb > 0) Console.Write($"{mb}Mb ");
            if (kb > 0) Console.Write($"{kb}Kb ");
            if (gb == 0 && mb == 0 && kb == 0) Console.Write("0 Bytes");
            
            Console.WriteLine();
        }
    }
}
