using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaGestionEmpleados
{
    public partial class frmGestionEmpleados : Form
    {
        public frmGestionEmpleados()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventanaAcercaDe = new frmAcercaDe();
            ventanaAcercaDe.ShowDialog();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoEmpleado ventanaAgregarNuevoEmpleado = new frmAgregarNuevoEmpleado();
            ventanaAgregarNuevoEmpleado.ShowDialog();  
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoGeneralEmpleados ventanaListadoGeneralEmpleados = new frmListadoGeneralEmpleados();
            ventanaListadoGeneralEmpleados.ShowDialog();
        }

        private void listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoEmpleadosPorCategoria ventanaListadoEmpleadosPorCategoria = new frmListadoEmpleadosPorCategoria();
            ventanaListadoEmpleadosPorCategoria.ShowDialog();
        }

        private void listadoDeEmpleadosConSueldoMayorAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarEmpleadosPorSueldoMayorA ventanaListarEmpleadosPorSueldoMayorA = new frmListarEmpleadosPorSueldoMayorA();
            ventanaListarEmpleadosPorSueldoMayorA.ShowDialog();
        }

        private void búsquedaDeUnEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado ventanaBuscarEmpleado = new frmBuscarEmpleado();
            ventanaBuscarEmpleado.ShowDialog();
        }

        private void consultaDeDatosDeUnEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDatosEmpleado ventanaConsultaDatosEmpleados = new frmConsultaDatosEmpleado();
            ventanaConsultaDatosEmpleados.ShowDialog();
        }

        private void frmGestionEmpleados_Load(object sender, EventArgs e)
        {
            RegistroEmpleado.empleados[0].codigo = 1;
            RegistroEmpleado.empleados[0].sueldo = 1500;
            RegistroEmpleado.empleados[0].categoria = 1;
            RegistroEmpleado.empleados[0].nombre = "Lucas Urriste";

            RegistroEmpleado.empleados[1].codigo = 2;
            RegistroEmpleado.empleados[1].sueldo = 70000;
            RegistroEmpleado.empleados[1].categoria = 2;
            RegistroEmpleado.empleados[1].nombre = "Guido Carrillo";

            RegistroEmpleado.empleados[2].codigo = 3;
            RegistroEmpleado.empleados[2].sueldo = 781500;
            RegistroEmpleado.empleados[2].categoria = 5;
            RegistroEmpleado.empleados[2].nombre = "Santiago Ascacibar";

            RegistroEmpleado.empleados[3].codigo = 4;
            RegistroEmpleado.empleados[3].sueldo = 780;
            RegistroEmpleado.empleados[3].categoria = 3;
            RegistroEmpleado.empleados[3].nombre = "Mauro Boselli";


            RegistroEmpleado.empleados[4].codigo = 5;
            RegistroEmpleado.empleados[4].sueldo = 70;
            RegistroEmpleado.empleados[4].categoria = 7;
            RegistroEmpleado.empleados[4].nombre = "Mariano Andujar";

            RegistroEmpleado.IND = 5;
        }
    }
}
