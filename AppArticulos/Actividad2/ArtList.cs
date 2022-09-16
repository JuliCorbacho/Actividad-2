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
                com.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Descripcion as Marca, C.Descripcion as Categoria \r\nfrom ARTICULOS A, MARCAS M, CATEGORIAS C\r\nWhere A.IdMarca = M.Id and A.IdCategoria = C.Id";
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
                    aux.brand.Descripcion = (string)lector["Marca"];
                    aux.category = new Categoria();
                    aux.category.Descripcion = (string)lector["Categoria"];
                    if (!(lector["ImagenUrl"] is DBNull))
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
                datos.setQuery("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)values('" + newArticle.code + "','" + newArticle.name + "','" + newArticle.description + "', @idBrand, @idCategory, @ImagenUrl,'" + newArticle.price + "')");
                datos.setearParametro("@idBrand", newArticle.brand.Id);
                datos.setearParametro("@idCategory", newArticle.category.Id);
                datos.setearParametro("@ImagenUrl", newArticle.img);
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
