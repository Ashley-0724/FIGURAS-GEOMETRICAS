using System;

// ===== CLASE NODO =====
public class Nodo
{
    public int Data;
    public Nodo Next;

    public Nodo(int data)
    {
        Data = data;
        Next = null;
    }
}

// ===== CLASE LISTA ENLAZADA =====
public class ListaSimple
{
    private Nodo head;

    public ListaSimple()
    {
        head = null;
    }

    // Insertar al final
    public void InsertarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (head == null)
        {
            head = nuevo;
        }
        else
        {
            Nodo actual = head;
            while (actual.Next != null)
            {
                actual = actual.Next;
            }
            actual.Next = nuevo;
        }
    }

    // EJERCICIO 1: Buscar y contar repeticiones
    public int Buscar(int valor)
    {
        int contador = 0;
        Nodo actual = head;

        while (actual != null)
        {
            if (actual.Data == valor)
            {
                contador++;
            }
            actual = actual.Next;
        }

        if (contador == 0)
        {
            Console.WriteLine("El dato no fue encontrado en la lista.");
        }

        return contador;
    }

    // EJERCICIO 2: Generar 50 números aleatorios
    public void GenerarAleatorios()
    {
        Random rnd = new Random();
        for (int i = 0; i < 50; i++)
        {
            InsertarFinal(rnd.Next(1, 1000));
        }
    }

    // EJERCICIO 2: Eliminar nodos fuera de un rango
    public void EliminarFueraDeRango(int min, int max)
    {
        // Eliminar nodos del inicio
        while (head != null && (head.Data < min || head.Data > max))
        {
            head = head.Next;
        }

        Nodo actual = head;

        while (actual != null && actual.Next != null)
        {
            if (actual.Next.Data < min || actual.Next.Data > max)
            {
                actual.Next = actual.Next.Next;
            }
            else
            {
                actual = actual.Next;
            }
        }
    }

    // Mostrar lista
    public void Mostrar()
    {
        Nodo actual = head;
        Console.Write("head -> ");
        while (actual != null)
        {
            Console.Write("[ " + actual.Data + " ] -> ");
            actual = actual.Next;
        }
        Console.WriteLine("null");
    }
}

// ===== PROGRAMA PRINCIPAL =====
class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();

        // ===== EJERCICIO 2 =====
        lista.GenerarAleatorios();
        Console.WriteLine("Lista original:");
        lista.Mostrar();

        Console.Write("Ingrese el valor mínimo del rango: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(Console.ReadLine());

        lista.EliminarFueraDeRango(min, max);

        Console.WriteLine("\nLista después de eliminar fuera del rango:");
        lista.Mostrar();

        // ===== EJERCICIO 1 =====
        Console.Write("\nIngrese el valor a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        int veces = lista.Buscar(buscar);
        if (veces > 0)
        {
            Console.WriteLine($"El número {buscar} se encontró {veces} veces en la lista.");
        }

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
