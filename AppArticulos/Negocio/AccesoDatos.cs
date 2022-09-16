using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conn;
        private SqlCommand com;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conn = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            com = new SqlCommand();
        }

        public void setQuery(string query)
        {
            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = query;
        }

        public void ejecutarLectura()
        {
            com.Connection = conn;
            try
            {
                conn.Open();
                lector = com.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            com.Connection = conn;
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearParametro(string parameterName, object value)
        {
            com.Parameters.AddWithValue(parameterName, value);
        }

        public void cerrarConexion()
        {
            if (lector != null) lector.Close();
            conn.Close();
        }
    }
}
