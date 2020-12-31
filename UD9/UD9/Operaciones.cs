using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    public class Operaciones
    {
        //Ejercicio 3
        private int numero1;
        private int numero2;

        public Operaciones(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int Numero1 { get => numero1; set => numero1 = value; }
        public int Numero2 { get => numero2; set => numero2 = value; }
    
        private int Suma()
        {
            return numero1 + numero2;
        }

        private int Resta()
        {
            return numero1 - numero2;
        }

        private int Multiplicacion()
        {
            return numero1 * numero2;
        }

        private int Division()
        {
            return numero1 / numero2;
        }

        public void Imprimir()
        {
            Console.WriteLine("El resultado de la suma es " + Suma());
            Console.WriteLine("El resultado de la resta es " + Resta());
            Console.WriteLine("El resultado de la multiplicacion es " + Multiplicacion());
            Console.WriteLine("El resultado de la division es " + Division());

        }
    }
}
