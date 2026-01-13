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

namespace presentacion
{
    public partial class frmBusquedaAvanzada : Form
    {
        public string Campo { get; private set; }
        public string Criterio { get; private set; }
        public string Filtro { get; private set; }

        public frmBusquedaAvanzada()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBusquedaAvanzada_Load(object sender, EventArgs e)
        {
            cbxCampoBA.Items.Add("Nombre");
            cbxCampoBA.Items.Add("Marca");
            cbxCampoBA.Items.Add("Categoria");
            cbxCampoBA.Items.Add("Precio");
        }

        private void cbxCampoBA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampoBA.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cbxCriterioBA.Items.Clear();
                cbxCriterioBA.Items.Add("Mayor a");
                cbxCriterioBA.Items.Add("Menor a");
                cbxCriterioBA.Items.Add("Igual a");

            }
            else
            {
                cbxCriterioBA.Items.Clear();
                cbxCriterioBA.Items.Add("Comienza con");
                cbxCriterioBA.Items.Add("Termina con");
                cbxCriterioBA.Items.Add("Contiene");
            }
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
        //Buscar mas validaciones para no solo mostrar puros cartelitos
        private bool validarFiltro()
        {
            if(cbxCampoBA.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if(cbxCriterioBA.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if(cbxCampoBA.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroBA.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(txtFiltroBA.Text)))
                {
                    MessageBox.Show("Solo números para filtrar por un campo numérico...");
                    return true;
                }
            }
            return false;
        }
        private void btnBuscarAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;
                Campo = cbxCampoBA.SelectedItem.ToString();
                Criterio = cbxCriterioBA.SelectedItem.ToString();
                Filtro = txtFiltroBA.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
