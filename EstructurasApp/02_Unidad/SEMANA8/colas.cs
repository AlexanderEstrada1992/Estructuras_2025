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
        string autoAtendido = autos.Dequeue(); //Extrae el primer elementos de la cola
        
        Console.WriteLine("Atendido: " + autoAtendido );
        int porVender = autos.Count();
        Console.WriteLine("tenemos " + porVender + " por vender");

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