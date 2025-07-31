using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio5
{
    public class Estudiante : Persona
    {
        private string carrera;

        public Estudiante(string nombre, string carrera) : base(nombre)
        {
            this.carrera = carrera;
        }

        public override string MostrarPerfil()
        {
            return $"Estudiante: {ObtenerNombre()} - Carrera: {carrera}";
        }

    }
}
