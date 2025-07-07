public class ListaSimple
{
    clsNodo head;
    public ListaSimple()
    {
        head = null;
    }


    public void InsertarInicio(string dato)
    {
        var nuevoNodo = new clsNodo(dato);
        nuevoNodo.Siguiente = head;
        head = nuevoNodo;
    }

    public void InsertarFinal(string dato)
    {
        clsNodo nuevoNodo = new clsNodo(dato);

        if (head == null)
        {
            head = nuevoNodo;
        }
        else
        {
            clsNodo actual = head;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }
}