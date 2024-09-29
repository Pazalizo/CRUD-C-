using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD_C_
{
    internal class Departamento
    {
        private string nombre;
        private Pais pais;
        public Departamento(string nombre ,Pais pais)
        {
            this.nombre = nombre;
            this.pais = pais;
        }
    }
}
