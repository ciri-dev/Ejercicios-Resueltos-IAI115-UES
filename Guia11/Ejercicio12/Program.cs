using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{   /*
     * 12- En la universidad se llevó a cabo un examen final de una especialización 
     * en la que participaron 10 estudiantes. Se hizo un examen para poder medir 
     * los aprendizajes de cada uno y el decanato decidió que a todos aquellos 
     * que hayan aprobado el examen con una nota mayor o igual a 7.0 se les 
     * otorgaría el título Senior y a los que obtuvieron menor nota se les daría 
     * el título de Junior en la especialidad finalizada.
     * a) Guarde los datos de los participantes con los nombres escritos tal como aparecen arriba (inicialice). Imprima los datos 
     * b) Cambie los nombres de los estudiantes a formato de sólo la primer letra de cada palabra en mayúsculas y lo demás minúsculas y lo guarde, imprima.  Ej: Camila Andrea Perez Alfaro  7.5 
     * c) Agregue el título correspondiente a cada nombre de acuerdo a la nota obtenida y guárdelos. Ej:  Senior Camila Andrea Perez Alfaro    7.5 
     * d) Presente un listado de los estudiantes con sus respectivas notas ordenados de la menor a la mayor nota. 
     * e) Obtenga el promedio de nota e indique quienes obtuvieron una nota arriba de la media. 
     */
    internal class Program
    {
        // Estructura para almacenar los datos del estudiante
        public struct Estudiante
        {
            public string nombreOriginal;
            public string nombreFormateado;
            public double nota;
            public string titulo;
        }

        static void Main(string[] args)
        {
            
            // a) Inicializar datos
            Estudiante[] estudiantes = InicializarEstudiantes();

            Console.WriteLine("\na) Datos originales:");
            MostrarEstudiantes(estudiantes, mostrarFormateado: false);

            // b) Formatear nombres
            FormatearNombres(estudiantes);
            Console.WriteLine("\nb) Nombres formateados:");
            MostrarEstudiantes(estudiantes, mostrarFormateado: true);

            // c) Asignar títulos
            AsignarTitulos(estudiantes);
            Console.WriteLine("\nc) Títulos asignados:");
            MostrarEstudiantesConTitulo(estudiantes);

            // d) Ordenar por nota
            Array.Sort(estudiantes, (a, b) => a.nota.CompareTo(b.nota));
            Console.WriteLine("\nd) Estudiantes ordenados por nota:");
            MostrarEstudiantesConTitulo(estudiantes);

            // e) Promedio y superiores a la media
            double promedio = CalcularPromedio(estudiantes);
            Console.WriteLine($"\ne) Promedio de notas: {promedio:0.00}");
            Console.WriteLine("Estudiantes con nota superior al promedio:");
            MostrarSuperioresAlPromedio(estudiantes, promedio);

            Console.ReadKey();
        }

        // a) Inicializa los datos originales
        static Estudiante[] InicializarEstudiantes()
        {
            string[] nombres = {
                "CAMILA ANDREA PEREZ ALFARO",
                "JOSMARY ELIZABETH RAMOS MEJIA",
                "JACKELINE ALEJANDER MELENDEZ PORTILLO",
                "DANIEL CAMILO MANCÍA SANCHEZ",
                "ROXANA ARELY CHEVEZ SEGOVIA",
                "MILENA JULIANA MARTINEZ URRUTIA",
                "HELIO MANRIQUE OCHOA VASQUEZ",
                "IRMA CONCEPCIÓN LOPEZ HERNÁNDEZ",
                "CARLOS RICARDO RIVERA PRAGA",
                "RAFAEL CONCEPCIÓN GARCIA PRIETO"
            };

            double[] notas = { 7.5, 10, 9.6, 6.7, 9.7, 8.0, 8.3, 8.9, 10, 6.0 };

            Estudiante[] lista = new Estudiante[nombres.Length];
            for (int i = 0; i < nombres.Length; i++)
            {
                lista[i].nombreOriginal = nombres[i];
                lista[i].nota = notas[i];
            }
            return lista;
        }

        // b) Formatea nombres a estilo título
        static void FormatearNombres(Estudiante[] estudiantes)
        {
            for (int i = 0; i < estudiantes.Length; i++)
            {
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                estudiantes[i].nombreFormateado = ti.ToTitleCase(estudiantes[i].nombreOriginal.ToLower());
            }
        }

        // c) Asigna título según nota
        static void AsignarTitulos(Estudiante[] estudiantes)
        {
            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i].titulo = estudiantes[i].nota >= 7.0 ? "Senior" : "Junior";
            }
        }

        // d) Muestra estudiantes con opción de nombre original o formateado
        static void MostrarEstudiantes(Estudiante[] estudiantes, bool mostrarFormateado)
        {
            foreach (var est in estudiantes)
            {
                string nombre = mostrarFormateado ? est.nombreFormateado : est.nombreOriginal;
                Console.WriteLine($"- {nombre}\t\t\tNota: {est.nota}");
            }
        }

        // Muestra estudiantes con título asignado
        static void MostrarEstudiantesConTitulo(Estudiante[] estudiantes)
        {
            foreach (var est in estudiantes)
            {
                Console.WriteLine($"- {est.titulo} {est.nombreFormateado}\t\t\tNota: {est.nota}");
            }
        }

        // e) Calcula promedio de notas
        static double CalcularPromedio(Estudiante[] estudiantes)
        {
            double suma = 0;
            foreach (var est in estudiantes)
                suma += est.nota;
            return suma / estudiantes.Length;
        }

        // Muestra estudiantes con nota superior al promedio
        static void MostrarSuperioresAlPromedio(Estudiante[] estudiantes, double promedio)
        {
            foreach (var est in estudiantes)
            {
                if (est.nota > promedio)
                    Console.WriteLine($"- {est.nombreFormateado}\t\t\tNota: {est.nota}");
            }
        }
        
    }
}
