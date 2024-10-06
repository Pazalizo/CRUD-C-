using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_
{
    class PersonaInscrito
    {
        private List<Persona>? listado;

		public PersonaInscrito()
		{
			listado = new List<Persona>();
		}

		public void ImprimirListado()
		{
			foreach (var item in listado)
			{
				Console.WriteLine(item);
			}
		}
		public void Adicionar(Persona persona)
		{
			listado.Add(persona);
		}
	}
}
