using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];
            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("Ingrese el dodigo de articulo");
                articulos[i].Codarticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Precio");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el dodigo de marca");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());

            }
        }
    }
}
