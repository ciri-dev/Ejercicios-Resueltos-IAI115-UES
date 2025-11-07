using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{   /*
     * 11- Se tiene el registro de notas de 10 estudiantes, ingresados de manera 
     * aleatoria. Se solicita que diseñe una solución informática que: 
     * a) Presente el listado de estudiantes por orden alfabético con sus respectivas notas 
     * b) Presente un listado de estudiantes con sus respectivas notas ordenados de menor a mayor nota 
     * c) Encuentre y muestre al estudiante con mayor nota y cual fue 
     * d) Encuentre y muestre número de aprobados y reprobados 
     * e) Cuál fue la nota menor
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] nombres = new string[10];
            double[] notas = new double[10];

            Console.WriteLine("=== Registro de estudiantes y notas ===");
            LeerDatos(nombres, notas);

            Console.WriteLine("\n=== a) Listado alfabético con notas ===");
            ImprimirOrdenAlfabetico(nombres, notas);

            Console.WriteLine("\n=== b) Listado por nota ascendente ===");
            ImprimirOrdenPorNota(nombres, notas);

            Console.WriteLine("\n=== c) Estudiante con mayor nota ===");
            MostrarMayorNota(nombres, notas);

            Console.WriteLine("\n=== d) Aprobados y reprobados ===");
            ContarAprobadosReprobados(notas);

            Console.WriteLine("\n=== e) Nota menor ===");
            MostrarNotaMenor(nombres, notas);
        }

        // Método para leer nombres y notas
        static void LeerDatos(string[] nombres, double[] notas)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Nombre del estudiante #{i + 1}: ");
                nombres[i] = Console.ReadLine();

                Console.Write($"Nota de {nombres[i]}: ");
                notas[i] = LeerNotaValida();
            }
        }

        // Validación de nota entre 0 y 10
        static double LeerNotaValida()
        {
            double nota;
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                Console.Write("Nota inválida. Ingrese una nota entre 0 y 10: ");
            }
            return nota;
        }

        // Ordenar alfabéticamente y mostrar
        static void ImprimirOrdenAlfabetico(string[] nombres, double[] notas)
        {
            string[] copiaNombres = (string[])nombres.Clone();
            double[] copiaNotas = (double[])notas.Clone();

            Array.Sort(copiaNombres, copiaNotas);

            for (int i = 0; i < copiaNombres.Length; i++)
            {
                Console.WriteLine($"{copiaNombres[i]}: {copiaNotas[i]:F2}");
            }
        }

        // Ordenar por nota ascendente y mostrar
        static void ImprimirOrdenPorNota(string[] nombres, double[] notas)
        {
            string[] copiaNombres = (string[])nombres.Clone();
            double[] copiaNotas = (double[])notas.Clone();

            for (int i = 0; i < copiaNotas.Length - 1; i++)
            {
                for (int j = i + 1; j < copiaNotas.Length; j++)
                {
                    if (copiaNotas[i] > copiaNotas[j])
                    {
                        // Intercambio de notas
                        double tempNota = copiaNotas[i];
                        copiaNotas[i] = copiaNotas[j];
                        copiaNotas[j] = tempNota;

                        // Intercambio de nombres
                        string tempNombre = copiaNombres[i];
                        copiaNombres[i] = copiaNombres[j];
                        copiaNombres[j] = tempNombre;
                    }
                }
            }

            for (int i = 0; i < copiaNombres.Length; i++)
            {
                Console.WriteLine($"{copiaNombres[i]}: {copiaNotas[i]:F2}");
            }
        }

        // Mostrar estudiante con mayor nota
        static void MostrarMayorNota(string[] nombres, double[] notas)
        {
            double mayor = notas[0];
            int indice = 0;

            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                    indice = i;
                }
            }

            Console.WriteLine($"Mayor nota: {nombres[indice]} con {mayor:F2}");
        }

        // Contar aprobados y reprobados
        static void ContarAprobadosReprobados(double[] notas)
        {
            int aprobados = 0, reprobados = 0;

            foreach (double nota in notas)
            {
                if (nota >= 6)
                    aprobados++;
                else
                    reprobados++;
            }

            Console.WriteLine($"Aprobados: {aprobados}");
            Console.WriteLine($"Reprobados: {reprobados}");
        }

        // Mostrar nota menor
        static void MostrarNotaMenor(string[] nombres, double[] notas)
        {
            double menor = notas[0];
            int indice = 0;

            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < menor)
                {
                    menor = notas[i];
                    indice = i;
                }
            }

            Console.WriteLine($"Nota menor: {nombres[indice]} con {menor:F2}");
        }
        
    }
}
