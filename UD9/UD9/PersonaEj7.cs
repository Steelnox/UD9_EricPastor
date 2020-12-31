using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    //Ejercicio 7
    public class PersonaEj7
    {
        private string nombre;
        private int edad;
        private string DNI;
        private char sexo;
        private float peso;
        private float altura;

        public PersonaEj7()
        {
            nombre = "";
            edad = 0;
            sexo = 'H';
            peso = 0;
            altura = 0;
            DNI = "00000000A";
        }

        public PersonaEj7(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
            this.DNI = "00000000A";
        }

        public PersonaEj7(string nombre, int edad, string dNI, char sexo, float peso, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            DNI = dNI;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Altura { get => altura; set => altura = value; }
    }
}
