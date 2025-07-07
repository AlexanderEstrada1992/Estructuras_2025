public class Semana4
{
    public static void run()
    {
        System.Console.WriteLine("  Listas");
        System.Console.WriteLine("=============================");

        // Crear una colección de strings llamada nombres
        List<string> nombres = ["Ana", "Luis", "Rosita"];

        // Añadir elementos a la lista
        nombres.Add("Romina");
        nombres.Add("Willy");
        nombres.Add("Ana");

        // Eliminar elemento de la lista
        nombres.Remove("Ana");

        // Ordenar una lista
        nombres.Sort();

        // Imprimir una lista
        foreach (string nombre in nombres)
        {
            System.Console.WriteLine(nombre.ToUpper());
        }

        // Cuenta los elementos de la lista
        System.Console.WriteLine($"La lista tiene {nombres.Count} elementos");

    }

}