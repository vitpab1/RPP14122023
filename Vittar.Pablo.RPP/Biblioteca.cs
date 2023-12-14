using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vittar.Pablo.RPP;

namespace Entidades
{
    public class Biblioteca
    {
        private List<Libro> libros;
        private string nombre;

        private Biblioteca(string nombre)
        {
            this.nombre = nombre;
            libros = new List<Libro>();
        }

        public static Biblioteca CrearBiblioteca(string nombre)
        {
            return new Biblioteca(nombre);
        }
        public List<Libro> Libros
        {
            get => libros;
        }

        public static string DetallarBiblioteca(Biblioteca biblioteca)
        {
            StringBuilder detalle = new StringBuilder();
            detalle.AppendLine($"Biblioteca: {biblioteca.nombre}");
            detalle.AppendLine("Listado de Libros:");

            foreach (var libro in biblioteca.libros)
            {
                detalle.AppendLine(libro.Detalle);
            }

            return detalle.ToString();
        }
        public static bool operator ==(Biblioteca biblioteca, Libro libro)
        {
            return biblioteca.libros.Contains(libro);
        }

        public static bool operator !=(Biblioteca biblioteca, Libro libro)
        {
            return !(biblioteca == libro);
        }

        public static Biblioteca operator +(Biblioteca biblioteca, Libro libro)
        {
            if (biblioteca != libro)
            {
                biblioteca.libros.Add(libro);
            }
            return biblioteca;
        }

        public static Biblioteca operator -(Biblioteca biblioteca, Libro libro)
        {
            if (biblioteca == libro)
            {
                biblioteca.libros.Remove(libro);
            }
            return biblioteca;
        }

        public static explicit operator Biblioteca(string nombre)
        {
            return new Biblioteca(nombre);
        }
    }
}
