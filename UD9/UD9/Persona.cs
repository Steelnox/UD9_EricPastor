using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    public class Persona
    {
        //Ejercicio 4
        private string nombre;

        public Persona()
        {
            nombre = "default";
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
            {
            return nombre;
            }
        public void SetNombre(string new_nombre)
        {
            nombre = new_nombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + nombre);
        }
    }
}
