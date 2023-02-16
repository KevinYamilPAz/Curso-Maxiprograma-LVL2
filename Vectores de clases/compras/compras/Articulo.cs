using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compras
{
    internal class Articulo
    {
        public int Codarticulo { get; set; }
        public float Precio { get; set; }

        private int Codmarca;
        public int CodigoMarca 
        {
            get { return Codmarca; }   
            set 
            {
                if (value > 0 && value < 11)
                {
                    Codmarca = value;
                }else Codmarca = -1;
            }
        }

    }
}
