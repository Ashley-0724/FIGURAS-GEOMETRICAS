using System;
using System.Collections.Generic;
using System.Linq;

namespace semana05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== MENÚ DE EJERCICIOS =====");
            Console.WriteLine("1. Lotería ordenada");
            Console.WriteLine("2. Números del 1 al 10 en orden inverso");
            Console.WriteLine("3. Asignaturas a repetir");
            Console.WriteLine("4. Contador de vocales");
            Console.WriteLine("5. Menor y mayor precio");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    new Ejercicio1().Ejecutar();
                    break;
                case 2:
                    new Ejercicio2().Ejecutar();
                    break;
                case 3:
                    new Ejercicio3().Ejecutar();
                    break;
                case 4:
                    new Ejercicio4().Ejecutar();
                    break;
                case 5:
                    new Ejercicio5().Ejecutar();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    // EJERCICIO 1
    class Ejercicio1
    {
        public void Ejecutar()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Ingrese 6 números ganadores de la lotería:");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            numeros.Sort();
            Console.WriteLine("Números ordenados de menor a mayor:");
            Console.WriteLine(string.Join(", ", numeros));
        }
    }

    // EJERCICIO 2
    class Ejercicio2
    {
        public void Ejecutar()
        {
            List<int> numeros = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            numeros.Reverse();
            Console.WriteLine("Números del 1 al 10 en orden inverso:");
            Console.WriteLine(string.Join(", ", numeros));
        }
    }

    // EJERCICIO 3
    class Ejercicio3
    {
        public void Ejecutar()
        {
            List<string> asignaturas = new List<string>
            {
                "Estadisticas", "Filosofia", "Química", "Historia", "Estructura de Datos"
            };

            List<string> repetir = new List<string>();

            foreach (string asignatura in asignaturas)
            {
                Console.Write($"Ingrese la nota de {asignatura}: ");
                double nota = double.Parse(Console.ReadLine());

                if (nota < 7)
                {
                    repetir.Add(asignatura);
                }
            }

            Console.WriteLine("Asignaturas que debe repetir:");
            if (repetir.Count > 0)
                Console.WriteLine(string.Join(", ", repetir));
            else
                Console.WriteLine("Ninguna");
        }
    }

    // EJERCICIO 4
    class Ejercicio4
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine().ToLower();

            Dictionary<char, int> vocales = new Dictionary<char, int>
            {
                { 'a', 0 }, { 'e', 0 }, { 'i', 0 }, { 'o', 0 }, { 'u', 0 }
            };

            foreach (char c in palabra)
            {
                if (vocales.ContainsKey(c))
                {
                    vocales[c]++;
                }
            }

            Console.WriteLine("Cantidad de vocales:");
            foreach (var v in vocales)
            {
                Console.WriteLine($"{v.Key}: {v.Value}");
            }
        }
    }

    // EJERCICIO 5
    class Ejercicio5
    {
        public void Ejecutar()
        {
            List<int> precios = new List<int> { 50, 33, 46, 22, 80, 65, 1 };

            int menor = precios.Min();
            int mayor = precios.Max();

            Console.WriteLine("Lista de precios:");
            Console.WriteLine(string.Join(", ", precios));
            Console.WriteLine($"Precio menor: {menor}");
            Console.WriteLine($"Precio mayor: {mayor}");
        }
    }
}
