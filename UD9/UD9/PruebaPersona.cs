using System;
using System.Collections.Generic;
using System.Text;

namespace UD9
{
    public class PruebaPersona
    {
        public void Main()
        {
            Persona perso1 = new Persona();
            Persona perso2 = new Persona();

            perso1.SetNombre("Hector");
            perso2.SetNombre("Laia");

            Console.WriteLine("Por favor {0} salude", perso1.GetNombre());
            perso1.Saludar();

            Console.WriteLine("Por favor {0} salude", perso2.GetNombre());
            perso2.Saludar();
        }
    }
}
