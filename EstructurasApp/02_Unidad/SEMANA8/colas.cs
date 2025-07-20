public class Colas
{
    public static void run()
    {
        Queue<string> autos = new Queue<string>();

        autos.Enqueue("Lada");
        autos.Enqueue("Audi");
        autos.Enqueue("Opel");
        autos.Enqueue("BMW");

        //autos.Dequeue();
        autos.Dequeue();

        imprimirCola(autos);
    }

    public static void imprimirCola(Queue<string> cola)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Los elementos de la cola son:");
        foreach (var item in cola)
        {
            System.Console.WriteLine(item);
        }
    }

}