using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_anejoDeModulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones o = new Operaciones();
            Articulo a = new Articulo();
            Articulo b = new Articulo();
            Articulo c = new Articulo();

            Console.WriteLine("---TIENDA--DEPORIVA---");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre del producto 1");
            a.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio");
            a.Precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del producto 2");
            b.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio");
            b.Precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del producto 3");
            c.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio");
            c.Precio = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            var Resultado = o.Calculo(a, b, c);
            var Fecha = DateTime.Today;

            Console.WriteLine("---Articulos---");
            Console.WriteLine("Nombre: " + a.Nombre + "  " + "Precio: " + a.Precio);
            Console.WriteLine("Nombre: " + b.Nombre + "  " + "Precio: " + b.Precio);
            Console.WriteLine("Nombre: " + c.Nombre + "  " + "Precio: " + c.Precio);
            Console.WriteLine("Precio total: " + Resultado);
            Console.WriteLine("Fecha: " + Fecha);
            Console.ReadKey();
        }
    }
}
