using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    public class Serie
    {
        private string titulo;
        private int n_temporadas;
        private bool entregado;
        private string genero;
        private string creador;

        public Serie()
        {
            titulo = "";
            n_temporadas = 3;
            entregado = false;
            genero = "";
            creador = "";
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
            n_temporadas = 3;
            entregado = false;
            genero = "";
        }

        public Serie(string titulo, int n_temporadas, bool entregado, string genero, string creador)
        {
            this.titulo = titulo;
            this.n_temporadas = n_temporadas;
            this.entregado = entregado;
            this.genero = genero;
            this.creador = creador;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int N_temporadas { get => n_temporadas; set => n_temporadas = value; }
        public bool Entregado { get => entregado; set => entregado = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Creador { get => creador; set => creador = value; }
    
    }
}
