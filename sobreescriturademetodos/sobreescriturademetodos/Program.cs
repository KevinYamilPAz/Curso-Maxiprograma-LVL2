using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobreescriturademetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            perro animal2 = new perro();
            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            foreach (Animal ruidos in animals)
            {
                Console.WriteLine(ruidos.Ruido());
            }
            Console.ReadKey();
        }
    }
}
