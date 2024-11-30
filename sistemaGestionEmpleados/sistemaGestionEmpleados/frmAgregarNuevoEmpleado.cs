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
    public partial class frmAgregarNuevoEmpleado : Form
    {
        public frmAgregarNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (RegistroEmpleado.IND < RegistroEmpleado.empleados.Length)
            {
                RegistroEmpleado.empleados[RegistroEmpleado.IND].codigo = Convert.ToInt32(txtCodigo.Text);
                RegistroEmpleado.empleados[RegistroEmpleado.IND].sueldo = Convert.ToDecimal(txtSueldo.Text);
                RegistroEmpleado.empleados[RegistroEmpleado.IND].nombre = txtNombreApellido.Text;
                RegistroEmpleado.empleados[RegistroEmpleado.IND].categoria = Convert.ToInt32(txtCategoria.Text);
                RegistroEmpleado.IND++;
                MessageBox.Show("¡Cargado!");
                resetFields();
            }
            else
            {
                MessageBox.Show("Ya no hay más espacio para cargar");
            }
        }

        public void resetFields()
        {
            txtCodigo.Text = "";
            txtNombreApellido.Text = "";
            txtSueldo.Text = "";
            txtCategoria.Text = "";
        }

        private void controlTextFields()
        {
            if (txtCodigo.Text != "" && txtNombreApellido.Text != "" && txtSueldo.Text != "" && txtCategoria.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            controlTextFields();
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            controlTextFields();
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            controlTextFields();
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            controlTextFields();
        }
    }
}
