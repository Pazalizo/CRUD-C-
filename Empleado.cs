using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_
{
    internal class Empleado: Persona
    {
        private Cargo cargo;
        private double salario;
        public Empleado(int id, string nombre, string apellido, Direccion direccion, Cargo cargo, double salario) : base(id, nombre, apellido, direccion)
        {
            this.cargo = cargo;
            this.salario = salario;
        }
    }
}
