public class pilas
{
    public static void run()
    {
        Console.WriteLine("Pilas");
        Console.WriteLine("=============================");

        Stack<int> numeros = new Stack<int>();

        numeros.Push(1);
        numeros.Push(2);
        numeros.Push(20);
        numeros.Push(4);

        //Recorrer los elementos de la pila
        foreach (var item in numeros)
        {
            System.Console.WriteLine(item);
        }

        int ultimo = numeros.Peek();
        Console.WriteLine("el último elemento es: " + ultimo);
        Console.WriteLine("ültimo elemento {0} y el doble de último es {1}", ultimo, ultimo * 2);
        Console.WriteLine($"ültimo elemento es: {ultimo}");

        //Eliminar elementos
        numeros.Pop();
        int eliminado = numeros.Pop();
        System.Console.WriteLine();


        //Recorrer los elementos de la pila
        foreach (int item in numeros)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("elemento eliminado: " + eliminado);
    }

    public static void ImprimirPila(Stack<string> pila)
    {
        System.Console.WriteLine("Los elementos de la pila son: ");
        foreach (var item in pila)
        {
            System.Console.WriteLine(item);
        }
    }
    
}