using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_
{
    internal class Estudiante: Persona
    {
        private string codigo;
        private string programa;
        private double promedio;
        public Estudiante(int id, string nombre, string apellido, Direccion direccion, string codigo, string programa, double promedio) : base(id, nombre, apellido, direccion)
        {
            this.codigo = codigo;
            this.programa = programa;
            this.promedio = promedio;
        }
    }
}
