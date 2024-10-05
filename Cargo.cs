using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_
{
    internal class Cargo: Todos
	{
        private int id;
        private string nombre;
		public Cargo(int id, string nombre)
		{
			this.id = id;
			this.nombre = nombre;
		}

		public string Informacion()
		{
			return "Cargo: " + nombre;
		}
	}
}
