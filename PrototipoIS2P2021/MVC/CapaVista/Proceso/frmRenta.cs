using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Proceso
{
    public partial class frmRenta : Form
    {
        string UsuarioAplicacion;
        Controlador con = new Controlador();
        public frmRenta(string usuario)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            CargarCombobox();
            CargarCombobox2();
        }
        public void CargarCombobox()
        {
            //llenado de combobox de Pais
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.ValueMember = "pkidcliente";
            cmbCliente.DataSource = con.funcObtenerCamposComboboxPais("pkidcliente", "nombre", "cliente", "estado");
            cmbCliente.SelectedIndex = -1;
        }
        public void CargarCombobox2()
        {
            //llenado de combobox de Pais
            cmbDVD.DisplayMember = "nombre";
            cmbDVD.ValueMember = "pkidProducto";
            cmbDVD.DataSource = con.funcObtenerCamposComboboxPais2("pkidproducto", "nombre", "productos", "estado");
            cmbDVD.SelectedIndex = -1;
        }

        private void frmRenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCliente.SelectedIndex != -1)
            {
                txtCliente.Text = cmbCliente.SelectedValue.ToString();
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDVD.SelectedIndex != -1)
            {
                txtNombre.Text = cmbDVD.SelectedValue.ToString();
            }
        }
    }
}
