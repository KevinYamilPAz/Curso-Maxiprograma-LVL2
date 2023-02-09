using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dni persona = new dni();
            dni persona2 = new dni();
            dni persona3 = new dni();
            persona.nombre = "kevin";
            persona2.nombre = "Juan";
            persona3.nombre = "marcelin";
            List<dni> lista = new List<dni>();
            lista.Add(persona);
            lista.Add(persona2);
            lista.Add(persona3);
            Console.WriteLine("La cantidad de gente en la lista de es : " + lista.Count);
            foreach (dni NuevoNombre in lista) 
            {
                Console.WriteLine("Sus nombre son : " + NuevoNombre.nombre);
            }
            Console.ReadKey();
        }
    }
}
