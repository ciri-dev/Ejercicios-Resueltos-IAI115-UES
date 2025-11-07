using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{   /*
     * 17- La FIA desea almacenar datos relativos a los N libros o revistas científicas de su biblioteca. 
     * Cada libro o revista científica, debe contener la siguiente información: 
     * a) Numero de referencia. 
     * b) Titulo   
     * c) Nombre del autor   
     * d) Editorial  
     * e) Clase de publicación (libro o revista)  
     * f) Numero de edición (solo libros)      
     * g) Año de publicación (solo libros) 
     * h) Nombre de la revista (solo revistas) 
     * Además, se requiere mostrar con cuantos libros y revistas cuenta la biblioteca, cuantos 
     * libros se tienen del año 2018 y cuantas revistas son de clase “medicina” 
     * (Sugerencia: haga una estructura libro y otra estructura revista).
     */
    internal class Program
    {
        // Estructura para libros
        public struct Libro
        {
            public string referencia;
            public string titulo;
            public string autor;
            public string editorial;
            public int edicion;
            public int añoPublicacion;
        }

        // Estructura para revistas
        public struct Revista
        {
            public string referencia;
            public string titulo;
            public string autor;
            public string editorial;
            public string clase;
            public string nombreRevista;
        }

        static void Main(string[] args)
        {
            
            Console.Write("Ingrese la cantidad de libros: ");
            int nLibros = LeerCantidad();

            Console.Write("Ingrese la cantidad de revistas: ");
            int nRevistas = LeerCantidad();

            Libro[] libros = new Libro[nLibros];
            Revista[] revistas = new Revista[nRevistas];

            LeerLibros(libros);
            LeerRevistas(revistas);

            Console.WriteLine($"\nTotal de libros: {libros.Length}");
            Console.WriteLine($"Total de revistas: {revistas.Length}");

            int libros2018 = ContarLibros2018(libros);
            Console.WriteLine($"Libros publicados en 2018: {libros2018}");

            int revistasMedicina = ContarRevistasMedicina(revistas);
            Console.WriteLine($"Revistas de clase 'medicina': {revistasMedicina}");

            Console.ReadKey();
        }

        static int LeerCantidad()
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor) || valor < 0)
                Console.Write("Ingrese un número válido: ");
            return valor;
        }

        static void LeerLibros(Libro[] libros)
        {
            for (int i = 0; i < libros.Length; i++)
            {
                Console.WriteLine($"\nLibro {i + 1}:");
                Console.Write("Número de referencia: "); libros[i].referencia = Console.ReadLine();
                Console.Write("Título: "); libros[i].titulo = Console.ReadLine();
                Console.Write("Autor: "); libros[i].autor = Console.ReadLine();
                Console.Write("Editorial: "); libros[i].editorial = Console.ReadLine();
                Console.Write("Número de edición: "); libros[i].edicion = int.Parse(Console.ReadLine());
                Console.Write("Año de publicación: "); libros[i].añoPublicacion = int.Parse(Console.ReadLine());
            }
        }

        static void LeerRevistas(Revista[] revistas)
        {
            for (int i = 0; i < revistas.Length; i++)
            {
                Console.WriteLine($"\nRevista {i + 1}:");
                Console.Write("Número de referencia: "); revistas[i].referencia = Console.ReadLine();
                Console.Write("Título: "); revistas[i].titulo = Console.ReadLine();
                Console.Write("Autor: "); revistas[i].autor = Console.ReadLine();
                Console.Write("Editorial: "); revistas[i].editorial = Console.ReadLine();
                Console.Write("Clase de publicación: "); revistas[i].clase = Console.ReadLine().ToLower();
                Console.Write("Nombre de la revista: "); revistas[i].nombreRevista = Console.ReadLine();
            }
        }

        static int ContarLibros2018(Libro[] libros)
        {
            int contador = 0;
            foreach (var libro in libros)
            {
                if (libro.añoPublicacion == 2018)
                    contador++;
            }
            return contador;
        }

        static int ContarRevistasMedicina(Revista[] revistas)
        {
            int contador = 0;
            foreach (var revista in revistas)
            {
                if (revista.clase == "medicina")
                    contador++;
            }
            return contador;
        }
        
    }
}
