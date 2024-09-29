namespace CRUD_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais Colombia = new Pais("Colombia");
            Departamento Meta = new Departamento("Meta", Colombia);
            Municipio Villavicencio = new Municipio("Villavicencio", Meta);
        }
    }
}
