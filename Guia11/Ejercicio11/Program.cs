using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {   /*
         * 11- Conociendo los datos de un estudiante: apellidos, nombres, y año 
         * de ingreso realice una función que devuelva el carnet del estudiante 
         * considerando primer carácter del primer apellido, primer carácter del 
         * segundo apellido, dos últimos dígitos del año de ingreso, y un número 
         * de 9 dígitos asignado al azar (investigue una función en C# que le 
         * permita generar un número al azar)
         */
        static void Main(string[] args)
        {
            Console.Title = "Generador de Carnet Estudiantil";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Write("Ingrese los apellidos (dos separados por espacio): ");
            string apellidos = LeerCadena();

            Console.Write("Ingrese los nombres: ");
            string nombres = LeerCadena();

            Console.Write("Ingrese el año de ingreso (ej. 2023): ");
            int año = LeerAño();

            string carnet = GenerarCarnet(apellidos, nombres, año);
            Console.WriteLine($"\nCarnet generado: {carnet}");

            Console.ReadKey();
        }

        // Lee una cadena no vacía
        static string LeerCadena()
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(texto))
                    Console.WriteLine("El campo no puede estar vacío.");
            } while (string.IsNullOrWhiteSpace(texto));
            return texto;
        }

        // Lee y valida el año de ingreso
        static int LeerAño()
        {
            int año;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out año) || año < 1900 || año > DateTime.Now.Year)
                    Console.WriteLine("Ingrese un año válido.");
            } while (año < 1900 || año > DateTime.Now.Year);
            return año;
        }

        // Genera el carnet estudiantil según las reglas del ejercicio
        static string GenerarCarnet(string apellidos, string nombres, int añoIngreso)
        {
            string[] partes = apellidos.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (partes.Length < 2)
                return "Error: Debe ingresar dos apellidos.";

            char inicial1 = char.ToUpper(partes[0][0]);
            char inicial2 = char.ToUpper(partes[1][0]);

            string añoStr = añoIngreso.ToString();
            string ultimosDos = añoStr.Substring(añoStr.Length - 2);

            Random rnd = new Random();
            string numeroAzar = rnd.Next(100000000, 999999999).ToString(); // 9 dígitos

            return $"{inicial1}{inicial2}{ultimosDos}{numeroAzar}";
        }
        
    }
}
