using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_
{
	class EstudiantesInscritos
	{
		private List<Estudiante>? listado;

		public EstudiantesInscritos()
		{
			listado = new List<Estudiante>();
		}

		public void ImprimirListado()
		{
            foreach (var item in listado)
            {
				Console.WriteLine(item);
            }
        }
		public void Adicionar(Estudiante estudiante)
		{
			listado.Add(estudiante);
		}
	}
}
