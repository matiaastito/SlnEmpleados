using LibreriaEmpleados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    [Table("Departamentos")]
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }

        public Departamento(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Empleados = new List<Empleado>();
        }

    }
}
