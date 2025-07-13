// Definimos la clase Nodo, que representa un elemento de la lista enlazada
public class Nodo
{
    // Campo de datos: aquí se almacena el valor del nodo
    public int Data;

    // Campo de referencia: aquí se almacena la dirección (referencia) del siguiente nodo
    public Nodo? Next;

    // Constructor de la clase Nodo
    // Recibe un número entero como parámetro y lo guarda en el campo Data
    public Nodo(int data)
    {
        // Se asigna el dato recibido al campo Data
        this.Data = data;

        // Se inicializa la referencia al siguiente nodo como null, ya que no apunta a nadie al principio
        this.Next = null;
    }
}
