using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{   /*
     * 17- Hacer un programa para una minitienda, el programa deberá tener un menú, 
        hacer una venta y cerrar el dia con el total vendido y el margen de ganancia. En el 
        método HacerVenta: pedirá, la cantidad, precio unitario del producto (costo de 
        compra del dueño de la minitienda) y precio de venta (con ganancia), luego 
        preguntará si desea ingresar otro producto a la venta. Cuando ya haya ingresado 
        todos los productos, mostrará el total a pagar y solicitará el monto con que cancela 
        el cliente, luego muestra el vuelto a devolver, hace una pausa y luego vuelve al 
        menú principal. 
        La opción (método) CerrarDia, muestra la cantidad de productos total vendido y 
        el total de ventas del dia, hace una pausa y se cierra. Reporta el margen de 
        ganancia del día 
     */
    internal class Program
    {
        // Variables globales para estadísticas del día
        static int productosVendidos = 0;
        static double totalVentas = 0;
        static double totalCosto = 0;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        HacerVenta();
                        break;
                    case 2:
                        CerrarDia();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                if (opcion != 2)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 2);
        }

        // Muestra el menú principal
        static void MostrarMenu()
        {
            Console.WriteLine("=== MINITIENDA ===");
            Console.WriteLine("1. Hacer Venta");
            Console.WriteLine("2. Cerrar Día");
            Console.WriteLine("==================");
        }

        // Método para realizar una venta
        static void HacerVenta()
        {
            double totalVenta = 0;
            double costoTotalVenta = 0;
            string respuesta;

            do
            {
                Console.Write("Ingrese la cantidad del producto: ");
                int cantidad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el precio unitario (costo de compra): $");
                double costoUnitario = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el precio de venta unitario: $");
                double precioVenta = double.Parse(Console.ReadLine());

                double subtotal = cantidad * precioVenta;
                double costoSubtotal = cantidad * costoUnitario;

                totalVenta += subtotal;
                costoTotalVenta += costoSubtotal;
                productosVendidos += cantidad;
                totalVentas += subtotal;
                totalCosto += costoSubtotal;

                Console.Write("¿Desea ingresar otro producto? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            Console.WriteLine($"\nTotal a pagar: ${totalVenta:0.00}");
            Console.Write("Ingrese el monto con que cancela el cliente: $");
            double pago = double.Parse(Console.ReadLine());

            double vuelto = pago - totalVenta;
            Console.WriteLine($"Vuelto a devolver: ${vuelto:0.00}");
        }

        // Método para cerrar el día y mostrar estadísticas
        static void CerrarDia()
        {
            Console.WriteLine("=== CIERRE DEL DÍA ===");
            Console.WriteLine($"Cantidad total de productos vendidos: {productosVendidos}");
            Console.WriteLine($"Total de ventas del día: ${totalVentas:0.00}");

            double ganancia = totalVentas - totalCosto;
            Console.WriteLine($"Margen de ganancia del día: ${ganancia:0.00}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
        
    }
}
