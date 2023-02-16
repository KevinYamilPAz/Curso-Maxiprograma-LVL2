using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            fecha = DateTime.Now;
            Console.WriteLine("La fecha actual es : " + fecha.ToString("dd/MM/yyyy"));
            //fecha = DateTime.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
