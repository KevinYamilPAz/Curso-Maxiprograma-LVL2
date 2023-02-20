using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Libreria para trabajar con base de datos SQL
using Dominio;

namespace PracticaPokedex
{
    public class PokemonNegocio
    {
        public List<Pokemon> ListarPokemons()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader Leer;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select P.Id,Nombre,P.Descripcion,UrlImagen,E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P,ELEMENTOS E, ELEMENTOS D Where P.IdTipo = E.Id and P.IdDebilidad =  D.Id"; //<------------aca se coloca el comando que se mandara a la DB.
                comando.Connection= conexion;

                conexion.Open();
                Leer = comando.ExecuteReader();
                while (Leer.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = Leer.GetInt32(0);
                    aux.Nombre = (string)Leer["Nombre"];
                    aux.Descripcion = Leer.GetString(2);
                    aux.URLimagen = Leer.GetString(3);
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = Leer.GetString(4);
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)Leer["Debilidad"];
                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void Agregar(Pokemon Nuevo)
        {

        }
        public void Modificar(Pokemon Nuevo)
        {

        }
        public void Remover(Pokemon Nuevo)
        {

        }
    }
    
}
