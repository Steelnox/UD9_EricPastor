using System;

namespace UD9
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alum = new Alumno("Eric", 27);
            Empleado emplea = new Empleado("Andreu", 3500);
            Operaciones opera = new Operaciones(10, 2);

            string opcion = "";
            Console.WriteLine("Escoja un numero de ejercicio entre el 1 y el 10 (ambos incluidos) ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    alum.UsoMetodos();
                    break;
                case "2":
                    emplea.UsoMetodos();
                    break;
                case "3":
                    opera.Imprimir();
                    break;
                default:
                    Console.WriteLine("Esa opción no funciona. Vuelve a intentarlo más tarde");
                    break;
            }
        }
    }
}
