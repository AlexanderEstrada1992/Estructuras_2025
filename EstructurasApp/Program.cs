System.Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
System.Console.WriteLine("=============================");
System.Console.WriteLine();
System.Console.WriteLine("Deber de la semana 6");

// Declaramos la clase principal del programa
class Program
{
    // Método principal donde se ejecuta el programa
    static void Main(string[] args)
    {
        // Creamos una nueva lista enlazada vacía
        ListaSimple lista = new ListaSimple();

        // Insertamos algunos elementos al inicio de la lista
        lista.InsertarInicio(10);
        lista.InsertarInicio(20);
        lista.InsertarInicio(30);

        // Insertamos elementos al final de la lista
        lista.InsertarFinal(40);
        lista.InsertarFinal(50);

        // Dibujamos la lista actual (mostramos sus elementos)
        lista.DibujarLista();

        // Contamos cuántos elementos hay en la lista
        int cantidad = lista.ContarElementos();

        // Mostramos el número de elementos en la lista
        // (imprimimos el resultado en pantalla)
        System.Console.WriteLine("Cantidad de elementos: " + cantidad);

        // Invertimos el orden de los elementos en la lista
        lista.InvertirLista();

        // Dibujamos la lista después de haberla invertido
        lista.DibujarLista();
    }
}










//Semana5.run();
//Semana4.run();
//EjemploAgenda.run();
//Agenda.run();

























