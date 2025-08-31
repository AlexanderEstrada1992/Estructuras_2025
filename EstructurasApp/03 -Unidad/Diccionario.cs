public class Diccionario
{
    public static void run()
    {
        // 1. Diccionario inicial
        Dictionary<string, string> palabras = new Dictionary<string, string>()
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"eye", "ojo"}
        };

        // Variable para controlar el menú
        int opcion = -1;

        // 2. Menú interactivo
        while (opcion != 0)
        {
             Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine()); 
        }
    }

}