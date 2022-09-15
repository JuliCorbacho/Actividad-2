using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Actividad2
{
    internal class ArticleList
    {
        public List<Article> Show()
        {
            List<Article> list = new List<Article>();
            SqlConnection conn = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conn.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "Select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS";
                com.Connection=conn;

                conn.Open();
                lector=com.ExecuteReader();

                while (lector.Read())
                {
                    Article aux = new Article();
                    aux.code = (string)lector["Codigo"];
                    aux.name = (string)lector["Nombre"];
                    aux.description = (string)lector["Descripcion"];
                    aux.brand = (int)lector["IdMarca"];
                    aux.category = (int)lector["IdCategoria"];
                    aux.img = (string)lector["ImagenUrl"];
                    aux.price = (decimal)lector["Precio"];

                    list.Add(aux); 

                }

                conn.Close();
                return list;
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
