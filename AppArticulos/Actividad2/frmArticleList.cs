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
                dgvArticulos.Columns["Description"].Visible = false;
                dgvArticulos.Columns["Code"].Visible = false;
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
            cargarCbBuscarPor();
        }

        private void cargarCbBuscarPor()
        {
            cbBuscarPor.Items.Add("Código");
            cbBuscarPor.Items.Add("Nombre artículo");
            cbBuscarPor.Items.Add("Descripción");
            //cbBuscarPor.Items.Add("Marca");
            //cbBuscarPor.Items.Add("Categoría");
            cbBuscarPor.Items.Add("Precio");
        }

        private void cargarCbCriterio()
        {
            string opcion = cbBuscarPor.SelectedItem.ToString();
            if (opcion == "Código" || opcion == "Nombre artículo" || opcion == "Descripción")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Igual a");
                cbCriterio.Items.Add("Contiene");
                cbCriterio.Items.Add("Comienza con");
                cbCriterio.Items.Add("Termina con");
            }
            if (opcion == "Precio")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Igual a");
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
            }
            /*if (opcion == "Marca")
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                try
                {
                    cbCriterio.DataSource = marcaNegocio.listar();
                    cbCriterio.ValueMember = "Id";
                    cbCriterio.DisplayMember = "Descripcion";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            if (opcion == "Categoría")
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                try
                {
                    cbCriterio.DataSource = categoriaNegocio.listar();
                    cbCriterio.ValueMember = "Id";
                    cbCriterio.DisplayMember = "Descripcion";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }*/
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Article itemSeleccionado = (Article) dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(itemSeleccionado.img);
            tbCode.Text=itemSeleccionado.code;
            tbName.Text=itemSeleccionado.name;
            tbBrand.Text = itemSeleccionado.brand.Descripcion;
            tbCategory.Text= itemSeleccionado.category.Descripcion;
            tbDescription.Text = itemSeleccionado.description;


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

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            btnAgregarArticulo_Click(sender, e);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            btnEliminarArticulo_Click(sender, e);
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            btnModificarArticulo_Click(sender, e);
        }

        private void borrarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEliminarArticulo_Click(sender, e);
        }

        private void agregarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAgregarArticulo_Click(sender, e);
        }

        private void modificarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnModificarArticulo_Click(sender, e);
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCbCriterio();
        }

        private bool validarFiltro()
        {
            if (cbBuscarPor.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccionar el campo que desea filtrar.");
                return true;
            }
            if (cbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccionar el criterio con el desea filtrar.");
                return true;
            }
            if (cbBuscarPor.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Cargar filtro para númericos");
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Debe cargar un número");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ArticleList lista = new ArticleList();

            try
            {
                if (validarFiltro())
                    return;

                string buscarPor = cbBuscarPor.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text.ToLower();

                dgvArticulos.DataSource = lista.filtrar(buscarPor, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void lbLimpiarFiltro_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
