using LibreriaEmpleados.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados.Models
{
    public class Cliente : Persona
    {
        public Cliente(string cuit, string telefono, int id, string nombre, string apellido) : base(id, nombre, apellido)
        {
            Cuit = cuit;
            Telefono = telefono;
        }

        public string Cuit { get; set; }
        public string Telefono { get; set; }


    }
}
