using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_
{
	internal class ListadoTodos
	{
		private List<Todos>? listado;
		public ListadoTodos()
		{
			listado = new List<Todos>();
		}
		public int cantidad()
		{
			return 0;
		}
		public void Adicionar(Todos todo)
		{
			listado.Add(todo);
		}
		public string Consultar(int id)
		{
			return "hola";
		}

		public void Mostrar()
		{
			foreach (Todos todo in listado)
			{
				Console.WriteLine(todo.Informacion());
			}
		}
	}
}
