using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvProductos.DataSource = listaArticulos;
                cargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception)
            {

                pbxImagen.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            cargar();
        }

    }
}
