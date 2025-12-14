using System;

namespace semana03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REGISTRO DE ESTUDIANTE ===");

            Console.Write("Ingrese ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nombres: ");
            string nombres = Console.ReadLine();

            Console.Write("Ingrese apellidos: ");
            string apellidos = Console.ReadLine();

            Console.Write("Ingrese dirección: ");
            string direccion = Console.ReadLine();

            string[] telefonos = new string[3];

            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.Write($"Ingrese teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }

            Estudiante estudiante = new Estudiante(id, nombres, apellidos, direccion, telefonos);
            estudiante.MostrarDatos();

            Console.ReadKey();
        }
    }
}
