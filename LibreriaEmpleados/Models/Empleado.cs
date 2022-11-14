using LibreriaEmpleados.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados.Models
{
    [Table("Empleados")]
    public class Empleado : Persona
    {
        public Empleado() { }
        public Empleado(string legajo, int id, string nombre, string apellido) : base(id, nombre, apellido)
        {
            Legajo = legajo;
        }

        
        public string Legajo { get; set; }

        public Departamento Departamento { get; set; }


    }
}
