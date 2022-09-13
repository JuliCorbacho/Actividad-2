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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
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
            //Articulo nuevoArt = new Articulo ();
            //ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                //Articulo.Codigo = txtCodigo.Text;
                //Articulo.Nombre = txtNombre.Text;
                //Articulo.Descripcion = txtDescripcion.Text;
                //Articulo.Marca = cbMarca.Text;
                //Articulo.Categoria = cbCategoria.Text;
                //Articulo.Precio = int.Parse(txtPrecio.Text);

                //negocio.Agregar(nuevoArt);
                //MessageBox.Show("Articulo agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
