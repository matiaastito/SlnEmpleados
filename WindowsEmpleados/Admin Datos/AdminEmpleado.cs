using LibreriaEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Datos;

namespace WindowsEmpleados.Admin_Datos
{
    public static class AdminEmpleado
    {  
        private static DBEmpleadosContext context = new DBEmpleadosContext();
        public static int Insertar(Empleado empleado)
        {
            context.Empleados.Add(empleado);
            int filasAfectadas = context.SaveChanges();
            
            return filasAfectadas;
        }

        public static List <Empleado> Listar()
        {

            
            return context.Empleados.ToList();
        }
    }
}
