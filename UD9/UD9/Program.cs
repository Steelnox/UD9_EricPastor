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
            Coche test_coche = new Coche();
            PersonaEj7 perso1 = new PersonaEj7("Marc", 24, "39587464J", 'H', 80.5f, 1.76f);
            Password contra = new Password(12);
            Electrodomestico electro = new Electrodomestico(90, "ROJO", 'F', 85);
            Serie serie = new Serie("La casa de papel", 5, true, "acción", "Roberto Salazar");

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
                case "6":
                    test_coche.Main();
                    break;
                case "7":
                    Console.WriteLine("Esta persona se llama {0}, tiene {1} años, su DNI es {2}, su sexo es {3}, pesa {4} kg y mide {5} m", perso1.Nombre, perso1.Edad, perso1.DNI1, perso1.Sexo, perso1.Peso, perso1.Altura);
                    break;
                case "8":
                    contra.MostrarContraseña();
                    break;
                case "9":
                    electro.Mostrar();
                    break;
                case "10":
                    Console.WriteLine("Esta serie tiene de titulo {0}, tiene {1} temporadas, es del genero {2} y el creador es {3}", serie.Titulo, serie.N_temporadas, serie.Genero, serie.Creador);
                    break;
                default:
                    Console.WriteLine("Esa opción no funciona. Vuelve a intentarlo más tarde");
                    break;
            }
        }
    }
}
