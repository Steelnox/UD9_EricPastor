using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    //Ejercicio1
    public class Alumno
    {
        private string nombre;
        private int edad;

        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        private void Imprimir()
        {
            Console.WriteLine("El alumno se llama {0} y tiene {1} años", nombre, edad);
        }

        private void MayorEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("El alumno es mayor de edad");
            }
            else
            {
                Console.WriteLine("El alumno es menor de edad");
            }
        }

        public void UsoMetodos()
        {
            Imprimir();
            MayorEdad();
        }
    }
}
