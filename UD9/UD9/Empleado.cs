using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    public class Empleado
    {
        private string nombre;
        private double sueldo;

        public Empleado(string nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
   
        private void Imprimir()
        {
            Console.WriteLine("El empleado {0} tiene un sueldo de {1}", nombre, sueldo);
        }

        private void Impuestos()
        {
            if(sueldo >= 3000)
            {
                Console.WriteLine("Este empleado tiene que pagar impuestos");
            }

            else
            {
                Console.WriteLine("Este empleado no tiene que pagar impuestos");
            }
        }

        public void UsoMetodos()
        {
            Imprimir();
            Impuestos();
        }
    }
}
