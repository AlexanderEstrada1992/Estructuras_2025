// Definimos la clase ListaSimple, que representa una lista simplemente enlazada
public class ListaSimple
{
    // Declaramos una variable de tipo Nodo llamada head (cabeza de la lista)
    // Esta variable apunta siempre al primer nodo de la lista
    Nodo? head;

    // Constructor de la clase ListaSimple
    // Inicializa la lista con head apuntando a null, es decir, la lista está vacía
    public ListaSimple()
    {
        head = null;
    }

    // Método para insertar un nodo al inicio de la lista
    public void InsertarInicio(int dato)
    {
        // Creamos un nuevo nodo con el dato recibido
        var nuevoNodo = new Nodo(dato);

        // El nuevo nodo apunta al que era anteriormente el primer nodo
        nuevoNodo.Next = head;

        // Ahora head pasa a apuntar al nuevo nodo, que está al inicio
        head = nuevoNodo;
    }

    // Método para insertar un nodo al final de la lista
    public void InsertarFinal(int dato)
    {
        // Creamos un nuevo nodo con el dato recibido
        Nodo nuevoNodo = new Nodo(dato);

        // Si la lista está vacía, el nuevo nodo será el primero
        if (head == null)
        {
            head = nuevoNodo;
        }
        else
        {
            // Si ya hay elementos, recorremos hasta el último nodo
            Nodo actual = head;
            while (actual.Next != null)
            {
                actual = actual.Next;
            }

            // Cuando llegamos al último nodo, hacemos que apunte al nuevo nodo
            actual.Next = nuevoNodo;
        }
    }

    // Método para contar cuántos elementos hay en la lista
    public int ContarElementos()
    {
        // Inicializamos un contador en cero
        int contador = 0;

        // Creamos una variable auxiliar para recorrer la lista desde el inicio
        Nodo? actual = head;

        // Mientras no lleguemos al final de la lista (null), seguimos recorriendo
        while (actual != null)
        {
            contador++;             // Contamos el nodo actual
            actual = actual.Next;   // Avanzamos al siguiente nodo
        }

        // Devolvemos el total de nodos contados
        return contador;
    }

    // Método para invertir el orden de los nodos en la lista
    public void InvertirLista()
    {
        // Usamos tres punteros: anterior, actual y siguiente
        Nodo? anterior = null;
        Nodo? actual = head;
        Nodo? siguiente = null;

        // Recorremos la lista y cambiamos las referencias de cada nodo
        while (actual != null)
        {
            siguiente = actual.Next;   // Guardamos el siguiente nodo
            actual.Next = anterior;    // Invertimos la dirección del puntero
            anterior = actual;         // Avanzamos anterior
            actual = siguiente;        // Avanzamos actual
        }

        // Al final, head apunta al último nodo que visitamos (que ahora es el primero)
        head = anterior;
    }

    // Método para mostrar la lista en pantalla
    public void DibujarLista()
    {
        // Creamos una variable auxiliar para recorrer la lista desde el inicio
        Nodo? actual = head;

        // Mostramos la palabra "head -->" al inicio
        System.Console.Write("head --> ");

        // Mientras no lleguemos al final (null), imprimimos los datos
        while (actual != null)
        {
            // Mostramos el valor del nodo actual
            System.Console.Write("[ " + actual.Data + " | * ]");

            // Si hay otro nodo después, mostramos una flecha -->
            if (actual.Next != null)
            {
                System.Console.Write(" --> ");
            }

            // Avanzamos al siguiente nodo
            actual = actual.Next;
        }

        // Mostramos que la lista termina en null
        System.Console.Write(" --> null\n");
    }
}
