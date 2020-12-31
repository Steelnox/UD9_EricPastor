using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    //Ejercicio 8
    public class Password
    {
        private int longitud;
        private char[] contraseña;

        public Password()
        {
            longitud = 8;
            contraseña = new char[longitud];
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            contraseña = new char[longitud];
            GenerarContraseña();
        }

        public int Longitud { get => longitud; set => longitud = value; }
        public char[] Contraseña { get => contraseña; set => contraseña = value; }

        private void GenerarContraseña()
        {
            Random rand = new Random();
            for (int i = 0; i < contraseña.Length; i++)
            {
                contraseña[i] = (char)rand.Next('A', 'Z');
            }
        }

        public void MostrarContraseña()
        {
            for (int i = 0; i < contraseña.Length; i++)
            {
                if(i == contraseña.Length - 1)
                {
                    Console.WriteLine(contraseña[i]);
                }
                else
                {
                    Console.Write(contraseña[i]);
                }
            }
        }
    }
}
