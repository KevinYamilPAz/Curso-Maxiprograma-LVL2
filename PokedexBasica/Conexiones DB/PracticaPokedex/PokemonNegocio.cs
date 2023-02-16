using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
//Libreria para trabajar con base de datos SQL

namespace PracticaPokedex
{
    internal class PokemonNegocio
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
                comando.CommandText = "Select Numero,Nombre,Descripcion,UrlImagen From POKEMONS"; //<------------aca se coloca el comando que se mandara ala DB.
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
    }
}
