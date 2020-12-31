using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    //Ejercicio 6
    public class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private float potencia;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        public float Potencia { get => potencia; set => potencia = value; }

        public Coche(string marca, string modelo, int cilindrada, float potencia)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.potencia = potencia;
        }

        public Coche()
        {
            marca = "default";
            modelo = "default";
            cilindrada = 0;
            potencia = 0.0f;
        }

        public void Main()
        {
            Coche coche1 = new Coche("Seat", "Ibiza", 9, 15.6f);
            Console.WriteLine("Es un coche de la marca {0} modelo {1} con {2} de cilindrada y {3} de potencia", coche1.Marca, coche1.Modelo, coche1.Cilindrada, coche1.Potencia);
        }
    }
}
