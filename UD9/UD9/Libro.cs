using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    public class Libro
    {
        //Ejercicio 5
        private string autor;
        private string titulo;
        private string ubicacion;

        public Libro()
        {
            autor = "default";
            titulo = "default";
            ubicacion = "default";
        }

        public Libro(string autor, string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }

        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    
        public void Main()
        {
            Libro libro1 = new Libro("Roberto de la cruz", "Cocina con Rodrigo", "Tarragona");
            Console.WriteLine("El libro se llama {0}, está escrito por {1} y fue escrito en {2}", libro1.Titulo, libro1.Autor, libro1.Ubicacion);
        }
    }
}
