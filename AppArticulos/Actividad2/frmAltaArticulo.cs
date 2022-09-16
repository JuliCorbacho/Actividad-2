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

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticleList negocio = new ArticleList();

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

                if(article.Id == 0)
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
