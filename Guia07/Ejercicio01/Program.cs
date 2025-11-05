using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{   /*
     * 1- Una tienda por departamentos vende productos nuevos (sellados), abiertos y usados 
     * (devueltos por los clientes). Dado el nombre y precio original de producto, departamento 
     * al que pertenece y si está nuevo, abierto o usado; se le pide desplegar el nombre del 
     * producto y el total a cancelar. Los departamentos y descuentos son Electrónicos 5%, 
     * Enseres 7% y Muebles 10%. Si el producto está sólo abierto tiene 25% descuento y usado 
     * 50% de descuento pero no se les aplica ningún descuento por departamento, sólo a los nuevos.
     */
    internal class Program
    {   
        // constantes con los descuentos
        public const float DESC1 = 0.05f, DESC2 = 0.07f, DESC3 = 0.10f;
        public const float DESCA = 0.25f, DESCU = 0.50f;
        static void Main(string[] args)
        {
            // Declaración de variables
            string nombre;
            char condicion;
            float precio, total;
            int depto;

            // Variables lógicas
            bool deptoCorrecto, condicionCorrecta;

            // Entrada de datos
            Console.WriteLine("Ingrese el nombre del Producto");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del Producto");
            precio = float.Parse(Console.ReadLine());

            Console.WriteLine("Departamento: \n1.Electronicos \n2.Enseres \n3.Muebles");
            depto = int.Parse(Console.ReadLine());

            Console.WriteLine("Condicion \n'n' nuevo \n'u' usado \n'a' abierto");
            condicion = Console.ReadLine().ToLower()[0];

            deptoCorrecto = depto >= 1 && depto <= 3;
            condicionCorrecta = condicion == 'n' || condicion == 'u' || condicion == 'a';

            if (EsPositivo(precio) && deptoCorrecto && condicionCorrecta)
            {
                total = precio - DescuentoXCondicion(precio, condicion) - DescuentoXDepto(precio, depto, condicion);
                Console.WriteLine("Producto: {0}, Total a pagar: ${1:0.00}", nombre, total);

                if (condicion == 'n')
                {
                    Console.WriteLine("Producto con garantía");
                }
                else
                {
                    Console.WriteLine("Producto sin garantía");
                }
            }
            else
            {
                Console.WriteLine("Error de datos ingresados");

                if (!EsPositivo(precio))
                {
                    Console.WriteLine("El precio debe de ser Positivo");
                }
                if (!deptoCorrecto)
                {
                    Console.WriteLine("Departamento debe de ser 1, 2 o 3");
                }
                if (!condicionCorrecta)
                {
                    Console.WriteLine("La condición debe de ser 'n','u','a' ");
                }
            }

            Console.ReadKey();
        }

        // Método para verificar si un número es positivo
        static bool EsPositivo(float num)
        {
            return num > 0;
        }

        // Método para calcular descuento según departamento (solo si el producto es nuevo)
        static float DescuentoXDepto(float precio, int depto, char condicion)
        {
            float descuento = 0;
            if (condicion == 'n')
            {
                switch (depto)
                {
                    case 1: descuento = DESC1 * precio; break;
                    case 2: descuento = DESC2 * precio; break;
                    case 3: descuento = DESC3 * precio; break;
                }
            }
            return descuento;
        }

        // Método para calcular descuento según condición del producto
        static float DescuentoXCondicion(float precio, char condicion)
        {
            float descuento = 0;
            switch (condicion)
            {
                case 'a': descuento = DESCA * precio; break;
                case 'u': descuento = DESCU * precio; break;
            }
            return descuento;
        }

    }
}
