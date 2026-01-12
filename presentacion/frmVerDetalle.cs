using dominio;
using negocio;
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

namespace presentacion
{
    public partial class frmVerDetalle : Form
    {
        private Articulo articulo;
        public frmVerDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcanegocio = new MarcaNegocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();
            try
            {
                cbxMarcaDetalle.ValueMember = "Id";
                cbxMarcaDetalle.DisplayMember = "Descripcion";
                cbxMarcaDetalle.DataSource = marcanegocio.listar();
                cbxCategoriaDetalle.ValueMember = "Id";
                cbxCategoriaDetalle.DisplayMember = "Descripcion";
                cbxCategoriaDetalle.DataSource = categorianegocio.listar();

                if (articulo != null)
                {
                    txtCodigoDetalle.Text = articulo.Codigo;
                    txtNombreDetalle.Text = articulo.Nombre;
                    txtDescripcionDetalle.Text = articulo.Descripcion;
                    txtImagenDetalle.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                    cbxMarcaDetalle.SelectedValue = articulo.Marca.Id;
                    cbxCategoriaDetalle.SelectedValue = articulo.Categoria.Id;
                    txtPrecioDetalle.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDetalle.Load(imagen);
            }
            catch (Exception)
            {

                pbxDetalle.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
            }
        }

        private void btnSalirDetalle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
