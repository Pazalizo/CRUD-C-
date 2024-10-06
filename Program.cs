namespace CRUD_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais Colombia = new Pais("Colombia");
            Departamento Meta = new Departamento("Meta", Colombia);
            Municipio Villavicencio = new Municipio("Villavicencio", Meta);
            Direccion direccion1 = new Direccion(Villavicencio, Meta, Colombia, "Calle 1", "Carrera 1", "1.1", "Casa 1");
            Estudiante Laura = new Estudiante(1, "Laura", "Rodriguez", direccion1, "1234567890", "Biologia", 3.5);

            Console.WriteLine(Laura.ToString());

			Todos Bartender = new Cargo(1, "Bartender");
			Todos Andres = new Persona(2, "Andres", "Rodriguez", direccion1);
			Todos Felipe = new Persona(1, "Felipe", "Huertas", direccion1);
			ListadoTodos lista = new ListadoTodos();
			EstudiantesInscritos listaEstudiantes = new EstudiantesInscritos();
			listaEstudiantes.Adicionar(Laura);
            //listaEstudiantes.ImprimirListado();
			lista.Adicionar(Andres);
            lista.Adicionar(Felipe);
            lista.Adicionar(Bartender);
			//lista.Mostrar();
		}
    }
}
