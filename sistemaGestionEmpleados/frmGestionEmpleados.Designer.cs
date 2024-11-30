namespace sistemaGestionEmpleados
{
    partial class frmGestionEmpleados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEmpleadosConSueldoMayorAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDatosDeUnEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaDeUnEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem,
            this.buscarClientesToolStripMenuItem,
            this.listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem,
            this.listadoDeEmpleadosConSueldoMayorAToolStripMenuItem,
            this.consultaDeDatosDeUnEmpleadoToolStripMenuItem,
            this.búsquedaDeUnEmpleadoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.clientesToolStripMenuItem.Text = "Empleado";
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            this.agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            this.agregarNuevosClientesToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.agregarNuevosClientesToolStripMenuItem.Text = "Agregar nuevo empleado...";
            this.agregarNuevosClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosClientesToolStripMenuItem_Click);
            // 
            // buscarClientesToolStripMenuItem
            // 
            this.buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            this.buscarClientesToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.buscarClientesToolStripMenuItem.Text = "Listado general de empleado...";
            this.buscarClientesToolStripMenuItem.Click += new System.EventHandler(this.buscarClientesToolStripMenuItem_Click);
            // 
            // listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem
            // 
            this.listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem.Name = "listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem";
            this.listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem.Text = "Listado de empleados de una categoria...";
            this.listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem_Click);
            // 
            // listadoDeEmpleadosConSueldoMayorAToolStripMenuItem
            // 
            this.listadoDeEmpleadosConSueldoMayorAToolStripMenuItem.Name = "listadoDeEmpleadosConSueldoMayorAToolStripMenuItem";
            this.listadoDeEmpleadosConSueldoMayorAToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listadoDeEmpleadosConSueldoMayorAToolStripMenuItem.Text = "Listado de empleados con sueldo mayor a...";
            this.listadoDeEmpleadosConSueldoMayorAToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosConSueldoMayorAToolStripMenuItem_Click);
            // 
            // consultaDeDatosDeUnEmpleadoToolStripMenuItem
            // 
            this.consultaDeDatosDeUnEmpleadoToolStripMenuItem.Name = "consultaDeDatosDeUnEmpleadoToolStripMenuItem";
            this.consultaDeDatosDeUnEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.consultaDeDatosDeUnEmpleadoToolStripMenuItem.Text = "Consulta de datos de un empleado...";
            this.consultaDeDatosDeUnEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDatosDeUnEmpleadoToolStripMenuItem_Click);
            // 
            // búsquedaDeUnEmpleadoToolStripMenuItem
            // 
            this.búsquedaDeUnEmpleadoToolStripMenuItem.Name = "búsquedaDeUnEmpleadoToolStripMenuItem";
            this.búsquedaDeUnEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.búsquedaDeUnEmpleadoToolStripMenuItem.Text = "Búsqueda de un empleado...";
            this.búsquedaDeUnEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.búsquedaDeUnEmpleadoToolStripMenuItem_Click);
            // 
            // frmGestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmGestionEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestión de empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestionEmpleados_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosConSueldoMayorAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosDeUnEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaDeUnEmpleadoToolStripMenuItem;
    }
}

