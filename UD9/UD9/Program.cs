﻿using System;

namespace UD9
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alum = new Alumno("Eric", 15);

            string opcion = "";
            Console.WriteLine("Escoja un numero de ejercicio entre el 1 y el 10 (ambos incluidos) ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    alum.UsoMetodos();
                    break;
                default:
                    Console.WriteLine("Esa opción no funciona. Vuelve a intentarlo más tarde");
                    break;
            }
        }
    }
}
