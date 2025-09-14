public class CatalogoRevistas
{
    // Arreglo estático para almacenar los títulos de las revistas
    static string[] revistas = new string[10];
    public static void run()
    {
        // Creación del catálogo
        revistas[0] = "Revista Ciencia Hoy";
        revistas[1] = "Tecnología Actual";
        revistas[2] = "Mundo Salud";
        revistas[3] = "Viajes y Aventuras";
        revistas[4] = "Cocina Fácil";
        revistas[5] = "Deportes al Día";
        revistas[6] = "Historia y Cultura";
        revistas[7] = "Innovación Empresarial";
        revistas[8] = "Arte y Diseño";
        revistas[9] = "Educación Global";

        // Variable para controlar el menú
        int opcion = 0;
        // Bucle que mantiene el menú activo hasta que el usuario elija salir
        do
        {
            // Mostrar las opciones del menú
            System.Console.WriteLine("\n--- MENÚ ---");
            System.Console.WriteLine("1. Buscar revista");
            System.Console.WriteLine("2. Salir");
            System.Console.Write("Ingrese una opción: ");
            opcion = int.Parse(System.Console.ReadLine());
             // Evaluar la opción ingresada
            switch (opcion)
            {
                case 1:
                    System.Console.Write("Ingrese el título a buscar: ");
                    string titulo = System.Console.ReadLine();
                    if (BuscarRecursivo(titulo, 0))
                        System.Console.WriteLine("Encontrado");
                    else
                        System.Console.WriteLine("No encontrado");
                    break;
                case 2:
                    System.Console.WriteLine("Saliendo...");
                    break;
                default:
                    System.Console.WriteLine("Opción inválida");
                    break;
            }
        } while (opcion != 2);
    }
    // Método de búsqueda recursiva
    static bool BuscarRecursivo(string titulo, int indice)
    {
        if (indice >= revistas.Length)
            return false; 
        if (revistas[indice].ToLower() == titulo.ToLower())
            return true;
        return BuscarRecursivo(titulo, indice + 1);
    }
}