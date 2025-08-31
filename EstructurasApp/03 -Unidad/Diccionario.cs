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

            // Opción 1: Traducir una frase
            if (opcion == 1)
            {
                Console.Write("\nIngrese una frase: ");
                string frase = Console.ReadLine().ToLower(); // Convertimos a minúsculas
                string[] palabrasFrase = frase.Split(' ');   // Separamos la frase por palabras

                Console.WriteLine("\nTraducción:");
                // Recorremos cada palabra ingresada
                foreach (var palabra in palabrasFrase)
                {
                    // Si la palabra está en el diccionario, se traduce
                    if (palabras.ContainsKey(palabra))
                    {
                        Console.Write(palabras[palabra] + " ");
                    }
                    // Si no existe en el diccionario, se deja igual
                    else
                    {
                        Console.Write(palabra + " ");
                    }
                }
            }
        }
    }

}