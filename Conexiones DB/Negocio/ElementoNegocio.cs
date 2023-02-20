using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    internal class ElementoNegocio
    {
        public List<Elemento> Listar()
        {
            List<Elemento>lista=new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select Id, Descripcion From ELEMENTOS");
                datos.ejecutarconsulta();

                while (datos.lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.ID = (int)datos.lector["Id"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];

                }



                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
