using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_1
{
    internal class Telefono
    {
        public Telefono(){ }
        //Atrivutos o miembros
        private string Modelo;
        private string Marca;
        private string NumeroTelefonico;
        private int CodigoOperdador;
        /////////////////////////////


        ///Metodos
        public void SetModelo(string M){Modelo = M;}
        public void SetMarca(string M){Marca = M;}
        public void SetNumero(string M){NumeroTelefonico = M;}
        public void SetCodigo(int M){ CodigoOperdador = M;}
        public string GetNumero(){return NumeroTelefonico;}
        public int GetCodigo(){ return CodigoOperdador; }

        public int ValidacionOperador(int M)
        {
            if (M < 4 || M > 0) 
            {
                Console.WriteLine("Ingreso de codigo valido ");
                SetCodigo(M);
                return 1;
            }
            else
            {
                
                Console.WriteLine("Ingreso de codigo invalido ");
                return -1;
            }
        }
        public void Llamar(){ Console.WriteLine("Realizando llamada.....");}
        /////////////////////////////////////////////////////////////////////
        ///Sobrecarga del metodo Llamara
        public void Llamar(String contacto){ Console.WriteLine("Llamanado a " + contacto); }
        //////////////////////////////////////////////////////////////////////
    }
    ///referenica hereda de telefono
    class referencia : Telefono 
    {
        public int Legajo { get; set; }
        public int Edad { get; set; }
    }
    ///////////////////////////////////
}
