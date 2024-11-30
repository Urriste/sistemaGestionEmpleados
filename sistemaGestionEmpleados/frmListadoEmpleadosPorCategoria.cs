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
    public partial class frmListadoEmpleadosPorCategoria : Form
    {
        public frmListadoEmpleadosPorCategoria()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Decimal totalSueldos = 0;
            Int32 cantidad = 0;
            Int32 categoriaSeleccionada = Convert.ToInt32(txtCategoriaListar.Text);

            dgvEmpleados.Rows.Clear();
            for (int i = 0; i < RegistroEmpleado.IND; i++)
            {
                if(categoriaSeleccionada == RegistroEmpleado.empleados[i].categoria)
                {
                    dgvEmpleados.Rows.Add(RegistroEmpleado.empleados[i].codigo, RegistroEmpleado.empleados[i].nombre, RegistroEmpleado.empleados[i].categoria, RegistroEmpleado.empleados[i].sueldo);
                    cantidad++;
                    totalSueldos = totalSueldos + RegistroEmpleado.empleados[i].sueldo;
                }

            }

            txtCantidadEmpleados.Text = cantidad.ToString();
            txtTotalSueldos.Text = totalSueldos.ToString();
        }
    }
}
