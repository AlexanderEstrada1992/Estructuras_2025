System.Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
System.Console.WriteLine("=============================");
System.Console.WriteLine();
System.Console.WriteLine("Deber de la semana 6");

// Clase que representa un nodo de la lista
public class Nodo
{
    public int Data;        // Campo que guarda el valor del nodo
    public Nodo? Next;      // Campo que apunta al siguiente nodo

    // Constructor que asigna el dato al nodo y apunta a null
    public Nodo(int data)
    {
        this.Data = data;
        this.Next = null;
    }
}

// Clase que representa la lista enlazada simple
public class ListaSimple
{
    private Nodo? head;  // Nodo que apunta al primer elemento de la lista

    // Constructor: la lista comienza vacía, con head en null
    public ListaSimple()
    {
        head = null;
    }

    // Método para insertar un nodo al inicio de la lista
    public void InsertarInicio(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato); // Creamos el nuevo nodo con el valor recibido
        nuevoNodo.Next = head;           // El nuevo nodo apunta al anterior primer nodo
        head = nuevoNodo;                // El nuevo nodo ahora es la cabeza de la lista
    }

    // Método para insertar un nodo al final de la lista
    public void InsertarFinal(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato); // Creamos el nuevo nodo

        if (head == null)                // Si la lista está vacía
        {
            head = nuevoNodo;           // El nuevo nodo es el primero (head)
        }
        else                             // Si ya hay elementos
        {
            Nodo actual = head;         // Empezamos desde el primer nodo
            while (actual.Next != null) // Recorremos hasta el último nodo
            {
                actual = actual.Next;
            }
            actual.Next = nuevoNodo;    // Enlazamos el último nodo al nuevo nodo
        }
    }

    // Método para contar cuántos elementos tiene la lista
    public int ContarElementos()
    {
        int contador = 0;              // Contador de nodos
        Nodo? actual = head;           // Empezamos desde el primero

        while (actual != null)        // Mientras haya nodos
        {
            contador++;               // Contamos el nodo
            actual = actual.Next;     // Pasamos al siguiente nodo
        }

        return contador;              // Retornamos el total
    }

    // Método para invertir el orden de los nodos en la lista
    public void InvertirLista()
    {
        Nodo? anterior = null;       // Nodo anterior (al principio es null)
        Nodo? actual = head;         // Empezamos desde el primer nodo
        Nodo? siguiente = null;      // Nodo siguiente

        while (actual != null)       // Mientras haya nodos
        {
            siguiente = actual.Next; // Guardamos el siguiente nodo
            actual.Next = anterior;  // Invertimos el puntero
            anterior = actual;       // Movemos el anterior
            actual = siguiente;      // Avanzamos al siguiente nodo
        }

        head = anterior;             // El nuevo primer nodo es el anterior
    }

    // Método para mostrar la lista en consola
    public void DibujarLista()
    {
        Nodo? actual = head;                 // Empezamos desde la cabeza
        System.Console.Write("head --> ");   // Imprimimos el inicio de la lista

        while (actual != null)              // Recorremos todos los nodos
        {
            System.Console.Write("[ " + actual.Data + " | * ]"); // Mostramos el valor del nodo

            if (actual.Next != null)
            {
                System.Console.Write(" --> ");  // Flecha si hay siguiente nodo
            }

            actual = actual.Next;           // Avanzamos al siguiente
        }

        System.Console.WriteLine(" --> null"); // Final de la lista
    }
}

// Programa principal para probar la lista
class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple(); // Creamos una lista vacía

        // Insertamos algunos elementos
        lista.InsertarFinal(10);
        lista.InsertarFinal(20);
        lista.InsertarFinal(30);
        lista.InsertarFinal(40);

        // Mostramos la lista original
        System.Console.WriteLine("Lista original:");
        lista.DibujarLista();

        // Mostramos cuántos elementos hay
        System.Console.WriteLine("\nNúmero de elementos en la lista:");
        System.Console.WriteLine(lista.ContarElementos());

        // Invertimos la lista
        lista.InvertirLista();

        // Mostramos la lista invertida
        System.Console.WriteLine("\nLista invertida:");
        lista.DibujarLista();
    }
}












//Semana5.run();
//Semana4.run();
//EjemploAgenda.run();
//Agenda.run();

























