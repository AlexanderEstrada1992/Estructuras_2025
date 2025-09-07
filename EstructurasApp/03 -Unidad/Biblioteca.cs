public class Biblioteca
{
    public static void run()
    {
        // Conjunto y mapa
        string[] titulos = new string[50];
        string[] autores = new string[50];
        int[] anios = new int[50];
        int contador = 0;

        int opcion = -1;

        // Menú Interactivo
        while (opcion != 0)
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Registrar un libro");
            Console.WriteLine("2. Mostrar todos los libros");
            Console.WriteLine("3. Buscar libro por título");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            // Opción 1: Registrar libro aplicando conjunto (no duplicados) y mapa
            if (opcion == 1)
            {
                if (contador < 50)
                {
                    Console.Write("Ingrese título del libro: ");
                    string titulo = Console.ReadLine();
                    
               }
            }

        }
    }

}