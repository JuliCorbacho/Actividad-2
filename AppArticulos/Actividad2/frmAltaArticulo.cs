using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Actividad2
{
    public partial class frmAltaArticulo : Form
    {
        private Article article = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Article art)
        {
            InitializeComponent();
            this.article = art;
            Text = "Modificar Articulo";

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   
            //agrego una flag para verificar si el código de articulo se repite o no
            int flag = 0;
            ArticleList negocio = new ArticleList();
            List<Article> checkCode = negocio.Show();

            try
            {   if(article == null)
                {
                    article = new Article();
                    article.Id = 0;
                }
                
                article.code = txtCodigo.Text;
                article.name = txtNombre.Text;
                article.description = txtDescripcion.Text;
                article.brand = (Marca)cbMarca.SelectedItem;
                article.category = (Categoria)cbCategoria.SelectedItem;
                article.img = txtURLimagen.Text;
                article.price = decimal.Parse(txtPrecio.Text);

                foreach(Article item in checkCode)
                {   
                    //para verificar si el código se repite, paso todo a mayuscula (dado que si se ingresa un lowercase el programa detecta los códigos como diferentes
                    //también verifico que el articulo que esté dando conflicto por el codigo repetido no tenga el mismo ID que el que estoy intentando modificar

                    if (item.code.ToUpper() == article.code.ToUpper() && item.Id!=article.Id && article.code!="")

                    {   //si el codigo se repite cambio la flag para que el registro no se guarde
                        MessageBox.Show("El código ingresado pertenece a otro articulo activo", "verificación de código", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = 1;
                        break;
                    }

                }

                if (flag==0)
                    {
                    //verifico que el precio sea mayor a 0
                    if (article.price < 0)
                    {
                        MessageBox.Show("Recuerde que el campo precio debe ser completado con un número mayor o igual a 0", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //se consulta al usuario si desea guardar su registro aún sin contar con datos en algunos de los campos
                    if ((article.name == "" || article.code == "" || article.description == "" || article.img == ""))
                    {
                        DialogResult opt = MessageBox.Show("Hay uno o más campos sin información, ¿Desea cargar el registro de todas maneras?", "Información incompleta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (opt == DialogResult.No)
                        {
                            return;
                        }
                    }
                    if (article.Id == 0)
                     {
                         negocio.Add(article);
                         MessageBox.Show("Articulo agregado exitosamente");
                     }
                     else
                     {
                         negocio.Modify(article);
                         MessageBox.Show("Articulo modificado exitosamente");
                     }
                     Close();

                 }


            }
            //excepción por ingreso de precio incorrecto (formato erroneo)
            catch (FormatException ex)
            {
                MessageBox.Show("Recuerde que el campo precio debe ser completado con un número mayor o igual a 0", "Error de formato",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";
                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

                if (article != null)
                {
                    txtCodigo.Text = article.code;
                    txtNombre.Text = article.name;
                    txtDescripcion.Text = article.description;
                    txtURLimagen.Text = article.img;
                    cargarImagen(article.img);
                    txtPrecio.Text = article.price.ToString();
                    cbMarca.SelectedValue = article.brand.Id;
                    cbCategoria.SelectedValue = article.category.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://us.123rf.com/450wm/mathier/mathier1905/mathier190500002/134557216-sin-imagen-en-miniatura-marcador-de-posici%C3%B3n-para-foros-blogs-y-sitios-web.jpg?ver=6");
            }
        }

        private void txtURLimagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtURLimagen.Text);
        }
    }
}
