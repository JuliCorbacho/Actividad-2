using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                dgvArticulos.DataSource = negocio.Show();
                dgvArticulos.Columns["img"].Visible = false;
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
            //Modificar articulo
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            //Eliminar articulo
        }

    }
}
