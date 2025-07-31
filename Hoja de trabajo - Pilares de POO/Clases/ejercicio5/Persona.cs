using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio5
{
    public abstract class Persona
    {
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public abstract string MostrarPerfil();
    }
}
