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
    public partial class frmListarEmpleadosPorSueldoMayorA : Form
    {
        public frmListarEmpleadosPorSueldoMayorA()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Decimal totalSueldos = 0;
            Int32 cantidad = 0;
            Decimal sueldoSeleccionado = Convert.ToDecimal(txtSueldoListar.Text);

            dgvEmpleados.Rows.Clear();
            for (int i = 0; i < RegistroEmpleado.IND; i++)
            {
                if (RegistroEmpleado.empleados[i].sueldo > sueldoSeleccionado)
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
