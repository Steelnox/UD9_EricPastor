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
            PruebaPersona test_perso = new PruebaPersona();
            Libro test_libro = new Libro();

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
                case "4":
                    test_perso.Main();
                    break;
                case "5":
                    test_libro.Main();
                    break;
                default:
                    Console.WriteLine("Esa opción no funciona. Vuelve a intentarlo más tarde");
                    break;
            }
        }
    }
}
