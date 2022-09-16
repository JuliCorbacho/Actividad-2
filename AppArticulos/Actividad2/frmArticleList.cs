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
    public partial class frmArticulos : Form
    {
        private List<Article> listaArticulo;

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void load()
        {
            ArticleList negocio = new ArticleList();
            try
            {
                listaArticulo = negocio.Show();
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["img"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
                cargarImagen(listaArticulo[0].img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Article itemSeleccionado = (Article) dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(itemSeleccionado.img);
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

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            //Ver detalles de articulo
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            load();

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Article selection;
            selection = (Article) dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modify = new frmAltaArticulo(selection);
            modify.ShowDialog();
            load();
        } 

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticleList articles = new ArticleList();
            Article selection;

            try
            {   
                //Se consulta al usuario si realmente desea eliminar el articulo de forma permanente
                DialogResult opt=MessageBox.Show("Esta acción eliminará permanentemente el registro, ¿Desea continuar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

                if (opt == DialogResult.Yes)
                {
                    selection = (Article)dgvArticulos.CurrentRow.DataBoundItem;
                    articles.Drop(selection.Id);
                    load();
                    MessageBox.Show("Eliminado correctamente");

                }
            }

            catch (Exception ex)
            {

            }

        }
    }
}
