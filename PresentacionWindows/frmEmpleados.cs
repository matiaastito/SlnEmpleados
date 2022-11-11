using LibreriaEmpleados;
using LibreriaEmpleados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class frmEmpleados : Form
    {
        Departamento departamento;
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnAgregarDpto_Click(object sender, EventArgs e)
        {
            departamento = new Departamento(Convert.ToInt32(txtIdDpto.Text), txtNombreDpto.Text);
            MessageBox.Show("Departamento añadido con exito");
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if(departamento != null)
            {
                departamento.Empleados.Add(new Empleado(txtLegajo.Text, Convert.ToInt32(txtIdEmpleado.Text), txtNombreEmpleado.Text, txtApellido.Text));
                MessageBox.Show("Empleado añadido con exito");
            }
            else
            {
                MessageBox.Show("Aun no se ha añadido ningun departamento valido");
            }
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            if (departamento != null && departamento.Empleados != null) 
            {
                gridEmpleadoXDpto.DataSource = departamento.Empleados;
            }
        }
    }
}
