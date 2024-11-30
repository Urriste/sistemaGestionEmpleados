using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaGestionEmpleados
{
    internal class RegistroEmpleado
    {
        public struct RegEmpleado
        {
            public Int32 codigo;
            public String nombre;
            public Int32 categoria;
            public Decimal sueldo;
        }

        public static RegEmpleado[] empleados = new RegEmpleado[100];
        public static Int32 IND;
    }
}
