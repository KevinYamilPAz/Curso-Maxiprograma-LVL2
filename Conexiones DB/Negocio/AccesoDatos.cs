using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataReader Lector;
        public SqlDataReader lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {

            Conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            Comando = new SqlCommand();
        }
        public void SetearConsulta(string consulta) 
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = consulta; 
        }
        public void ejecutarconsulta() 
        {
            Comando.Connection = Conexion;
            try
            {
            Conexion.Open();
            Lector= Comando.ExecuteReader();
            }
            catch (Exception EX)
            {

                throw EX;
            }
           
        }

        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
                Conexion.Close();
            }
        }
    }
}
