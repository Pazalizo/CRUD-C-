using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_
{
    internal class Direccion
    {
        private string calle;
        private Pais pais;
        private Departamento departamento;
        private Municipio municipio;
        private string carrera;
        private string coordenada;
        private string descripcion;
        public Direccion(Municipio municipio, Departamento departamento, Pais pais, string calle, string carrera, string coordenada, string descripcion)
        {
            this.calle = calle;
            this.pais = pais;
            this.departamento = departamento;
            this.municipio = municipio;
            this.carrera = carrera;
            this.coordenada = coordenada;
            this.descripcion = descripcion;
        }
    }
}
