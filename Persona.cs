using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_
{
    internal class Persona: Todos
    {
        private int id;
        private string nombre;
        private string apellido;
        private Direccion direccion;
        public Persona(int id, string nombre, string apellido, Direccion direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
        }
        
    }
}