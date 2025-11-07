using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{   /*
     * 5- Elabore un archivo en exel con extensión .csv en el cual se encuentren 
     * los siguientes datos de una cadena de supermercados: 
     * ID de la Sucursal, Nombre de la sucursal, Direccion, Telefono, No. De Empleados. 
     * (Esto seria el encabezado que no estará en el archivo. Ese archivo solo debe contener datos)
     * Realice una solución informática que  
     * Permita ingresar mas datos al registro sin eliminar los anteriores 
     * Permita visualizar el archivo, Imprima los encabezados respetivos y trate de mostrar en forma de tabla. 
     * Abra el archivo en Excel 
     * Permita visualizar solamente los registros realizados durante el dia (memoria RAM). Para esto deberá crear un vector de tipo struct de sucursales y mostrar todos los elementos que contengan información. 
     * Presente un menú de opciones y se repita todas las veces que sea necesario.
     */
    public struct Sucursal
    {
        public string id;
        public string nombre;
        public string direccion;
        public string telefono;
        public int empleados;
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            string rutaArchivo = "Sucursales.csv";
            List<Sucursal> sucursalesRAM = new List<Sucursal>();

            int opcion;
            do
            {
                MostrarMenu();
                opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        Sucursal nueva = LeerSucursal();
                        sucursalesRAM.Add(nueva);
                        GuardarSucursalEnArchivo(rutaArchivo, nueva);
                        Console.WriteLine("Sucursal agregada correctamente.");
                        break;

                    case 2:
                        MostrarArchivoConEncabezados(rutaArchivo);
                        break;

                    case 3:
                        AbrirArchivoEnExcel(rutaArchivo);
                        break;

                    case 4:
                        MostrarSucursalesRAM(sucursalesRAM);
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 5);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== MENÚ DE OPCIONES ===");
            Console.WriteLine("1. Agregar nueva sucursal");
            Console.WriteLine("2. Ver archivo CSV con encabezados");
            Console.WriteLine("3. Abrir archivo en Excel");
            Console.WriteLine("4. Ver sucursales ingresadas en esta sesión");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static int LeerOpcion()
        {
            return int.TryParse(Console.ReadLine(), out int op) ? op : -1;
        }

        static Sucursal LeerSucursal()
        {
            Sucursal s;
            Console.WriteLine("\nIngrese los datos de la sucursal:");
            Console.Write("ID: "); s.id = Console.ReadLine();
            Console.Write("Nombre: "); s.nombre = Console.ReadLine();
            Console.Write("Dirección: "); s.direccion = Console.ReadLine();
            Console.Write("Teléfono: "); s.telefono = Console.ReadLine();
            Console.Write("Número de empleados: ");
            while (!int.TryParse(Console.ReadLine(), out s.empleados) || s.empleados < 0)
                Console.Write("Ingrese un número válido: ");
            return s;
        }

        static void GuardarSucursalEnArchivo(string ruta, Sucursal s)
        {
            using (StreamWriter sw = new StreamWriter(ruta, append: true))
            {
                sw.WriteLine($"{s.id},{s.nombre},{s.direccion},{s.telefono},{s.empleados}");
            }
        }

        static void MostrarArchivoConEncabezados(string ruta)
        {
            Console.WriteLine("\nID | Nombre | Dirección | Teléfono | Empleados");
            if (File.Exists(ruta))
            {
                foreach (var linea in File.ReadAllLines(ruta))
                {
                    var datos = linea.Split(',');
                    if (datos.Length == 5)
                    {
                        Console.WriteLine($"{datos[0],3} | {datos[1],10} | {datos[2],40} | {datos[3],8} | {datos[4],3}");
                    }
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }
        }

        static void AbrirArchivoEnExcel(string ruta)
        {
            if (File.Exists(ruta))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }
        }

        static void MostrarSucursalesRAM(List<Sucursal> sucursales)
        {
            Console.WriteLine("\nSucursales ingresadas en esta sesión:");
            foreach (var s in sucursales)
            {
                Console.WriteLine($"{s.id} | {s.nombre} | {s.direccion} | {s.telefono} | {s.empleados}");
            }
        }
    }
}
