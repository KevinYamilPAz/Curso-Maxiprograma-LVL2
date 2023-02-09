using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*En este proyecto se implementan clases,herencia,metodos,Sobrecarga de metodo*/
namespace Desafío_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int opc;
            referencia persona;//creacion de la varible
            persona = new referencia();//Inicializacion de una instancia del objeto
            referencia estudiante;
            estudiante = new referencia();
            string contacto;
            while (true)
            {
                
                
                Console.WriteLine("Elija una opcion :\n\n");
                Console.WriteLine("1 Ingreso de datos");
                Console.WriteLine("2 Mostrar datos");
                Console.WriteLine("3 LLamar");
                Console.WriteLine("4 Llamar a contacto\n\n\n");
                Console.Write("Elija la opcion : ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        IngresoDatos(ref persona);
                        cargaAdicional(ref persona);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Mostrardatos(persona);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        persona.Llamar();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Ingrese el contacto que desea llamar : ");
                        contacto = Console.ReadLine();
                        persona.Llamar(contacto);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingreso de dato incorrecto");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        static referencia IngresoDatos(ref referencia p )
        {
            Console.Clear();
            string m;
            int n = -5;
            Console.WriteLine("ingrese el modelo : ");
            m = Console.ReadLine();
            p.SetModelo(m);
            Console.Clear();
            Console.WriteLine("ingrese la marca : ");
            m = Console.ReadLine();
            p.SetMarca(m);
            Console.Clear();
            while (n==-5) 
            {
                Console.WriteLine("ingrese el codigo de operador : ");
                n = int.Parse(Console.ReadLine());
                p.ValidacionOperador(n);
                Console.Clear();
            }
            Console.WriteLine("ingrese su numero : ");
            m = Console.ReadLine();
            p.SetNumero(m);
            return p;
        }
        static void Mostrardatos(referencia persona)
        {
            Console.WriteLine("Su codigo de operador es : " + persona.GetCodigo() + "\nSu numero actual es : "+ persona.GetNumero());
            Console.WriteLine("Legajo : " + persona.Legajo + "y su edad es : " + persona.Edad);
        }
        static referencia cargaAdicional(ref referencia aux)
        {

            Console.Clear();
            Console.Write("Ingrese su legajo : ");
            aux.Legajo =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad : ");
            aux.Edad=int.Parse(Console.ReadLine());
            return aux;

        }
    }
}
