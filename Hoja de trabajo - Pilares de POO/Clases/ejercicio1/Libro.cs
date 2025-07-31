using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio1
{
    public class Libro
    {
        private int id;
        private string titulo;
        private string autor;
        private bool disponible;
        private string usuario;

        public Libro(int id, string titulo, string autor)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.disponible = true;
            this.usuario = "";
        }

        public string ObtenerTitulo()
        {
            return titulo;
        }

        public bool EstaDisponible()
        {
            return disponible;
        }

        public bool Prestar(string usuario)
        {
            if (!disponible)
            {
                return false;
            }

            disponible = false;
            this.usuario = usuario;
            return true;
        }

        public string Mostrar()
        {
            if (disponible)
                return $"[{id}] {titulo} - {autor} (Disponible)";
            else
                return $"[{id}] {titulo} - {autor} (Prestado a {usuario})";
        }

    }
}
