using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio5
{
    public class Maestro : Persona
    {
        private string especialidad;

        public Maestro(string nombre, string especialidad) : base(nombre)
        {
            this.especialidad = especialidad;
        }

        public override string MostrarPerfil()
        {
            return $"Maestro: {ObtenerNombre()} - Especialidad: {especialidad}";
        }
    }
}
