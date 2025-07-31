using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio5
{
    public class Escuela
    {
        private List<Persona> personas;

        public Escuela()
        {
            personas = new List<Persona>();
        }

        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void MostrarPerfiles()
        {
            Console.WriteLine("\n== Perfiles en la escuela ==");
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.MostrarPerfil());
            }

        }
    }
}
