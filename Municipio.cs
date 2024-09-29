using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_
{
    internal class Municipio
    {
        private string nombre;
        private Departamento departamento;
        public Municipio(string nombre, Departamento departamento)
        {
            this.nombre = nombre;
            this.departamento = departamento;
        }
    }
}
