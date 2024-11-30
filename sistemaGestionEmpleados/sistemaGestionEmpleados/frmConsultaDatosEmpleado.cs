using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaGestionEmpleados
{
    public partial class frmConsultaDatosEmpleado : Form
    {
        public frmConsultaDatosEmpleado()
        {
            InitializeComponent();
        }

        private void frmConsultaDatosEmpleado_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < RegistroEmpleado.IND; i++) {

                cbxClientes.Items.Add(RegistroEmpleado.empleados[i].nombre);

            }
        }

        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxClientes.Text != "") {
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 indice = cbxClientes.SelectedIndex;

            txtCodigo.Text = RegistroEmpleado.empleados[indice].codigo.ToString();
            txtCategoria.Text = RegistroEmpleado.empleados[indice].categoria.ToString();
            txtSueldo.Text = RegistroEmpleado.empleados[indice].sueldo.ToString();
        }
    }
}
