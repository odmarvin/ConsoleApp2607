using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio1
{
    public class Biblioteca
    {
        private List<Libro> libros;
        private int siguienteId;

        public Biblioteca()
        {
            libros = new List<Libro>();
            siguienteId = 1;
        }

        public void RegistrarLibro(string titulo, string autor)
        {
            foreach (var libro in libros)
            {
                if (libro.ObtenerTitulo().Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Este libro ya esta registrado.");
                    return;
                }
            }

            libros.Add(new Libro(siguienteId, titulo, autor));
            siguienteId++;
        }

        public void PrestarLibro(string titulo, string usuario)
        {
            foreach (var libro in libros)
            {
                if (libro.ObtenerTitulo().Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    if (libro.EstaDisponible())
                    {
                        libro.Prestar(usuario);
                        Console.WriteLine("Libro prestado con exito.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("El libro ya está prestado.");
                        return;
                    }
                }
            }

            Console.WriteLine("Libro no encontrado.");
        }

        public void MostrarDisponibles()
        {
            Console.WriteLine("Libros disponibles:");
            foreach (var libro in libros)
            {
                if (libro.EstaDisponible())
                {
                    Console.WriteLine(libro.Mostrar());
                }
            }
        }


    }

}
