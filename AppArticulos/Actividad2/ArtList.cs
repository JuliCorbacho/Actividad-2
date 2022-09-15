using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;

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
                    aux.brand = new Marca();
                    aux.brand.Id = (int)lector["IdMarca"];
                    aux.category = new Categoria();
                    aux.category.Id = (int)lector["IdCategoria"];
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

        public void Add(Article newArticle)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)values(" + newArticle.code + ", '" + newArticle.name + "', '" + newArticle.description + "', 1, @idBrand, @idCategory, @urlImagen)" + "'" + newArticle.price + "'");
                datos.setearParametro("@idBrand", newArticle.brand.Id);
                datos.setearParametro("@idDebilidad", newArticle.category.Id);
                datos.setearParametro("@urlImagen", newArticle.img);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
