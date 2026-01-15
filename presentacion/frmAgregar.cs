using dominio;
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
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace presentacion
{
    public partial class frmAgregar : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcanegocio = new MarcaNegocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio(); 
            try
            {
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.DataSource = marcanegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categorianegocio.listar();

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       
        private bool validarArticulo()
        {
            bool valido = true;
            errorProvider.Clear();  

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider.SetError(txtCodigo, "El código es obligatorio");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, "La descripción es obligatoria");
                valido = false;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                errorProvider.SetError(txtPrecio, "Ingrese un valor numérico válido");
                valido = false;
            }
            else if (precio <= 0)
            {
                DialogResult resultado = MessageBox.Show("El precio es 0 o menor.\n¿Desea continuar?","Confirmar precio", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (resultado == DialogResult.No)
                {
                    valido = false;
                }
            }

            return valido;
        }
        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (!validarArticulo())
                    return;

                if(articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.UrlImagen = txtImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                
                

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("El artículo se modificó correctamente!", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente!", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (archivo != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
                {
                    string extension = Path.GetExtension(archivo.FileName);
                    string nombreSinExtension = Path.GetFileNameWithoutExtension(archivo.FileName);

                    string nuevoNombre = $"{nombreSinExtension}_{DateTime.Now:yyyyMMddHHmmssfff}{extension}";

                    string rutaDestino = Path.Combine(
                        ConfigurationManager.AppSettings["Images-folder"],
                        nuevoNombre);

                    File.Copy(archivo.FileName, rutaDestino);

                }
                
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAgregar.Load(imagen);
            }
            catch (Exception)
            {

                pbxAgregar.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
            }
        }


        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void btnAgregarImagen_MouseEnter(object sender, EventArgs e)
        {
            btnAgregarImagen.BackColor = SystemColors.MenuHighlight;
        }

        private void btnAgregarImagen_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarImagen.BackColor = SystemColors.InactiveCaption;
        }
    }
}
