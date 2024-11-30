using System;
using System.Windows.Forms;

namespace sistemaGestionEmpleados
{
    public partial class frmBuscarEmpleado : Form
    {
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 codigoABuscar = Convert.ToInt32(txtEmpleadoBuscar.Text);
            Int32 indice = 0;

            while (RegistroEmpleado.empleados[indice].codigo != codigoABuscar && indice < RegistroEmpleado.IND ) {
                indice++;
            }
            
            if (indice == RegistroEmpleado.IND) {

                MessageBox.Show("Código inexistente");
            }
            else
            {
                txtCategoria.Text = RegistroEmpleado.empleados[indice].categoria.ToString();
                txtNombre.Text = RegistroEmpleado.empleados[indice].nombre;
                txtSueldo.Text = RegistroEmpleado.empleados[indice].sueldo.ToString();
                txtCodigo.Text = RegistroEmpleado.empleados[indice].codigo.ToString();
            }

        }

       
    }
}
