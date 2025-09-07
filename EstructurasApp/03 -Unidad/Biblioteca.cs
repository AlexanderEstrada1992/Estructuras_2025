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

                    // Verificar si el título ya existe (conjunto)
                    bool existe = false;
                    for (int i = 0; i < contador; i++)
                    {
                        if (titulos[i] == titulo)
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (existe)
                    {
                        Console.WriteLine("El libro ya está registrado (conjunto de títulos).\n");
                    }
                    else
                    {
                        // Registrar libro (mapa: título -> autor y año)
                        Console.Write("Ingrese autor del libro: ");
                        string autor = Console.ReadLine();

                        Console.Write("Ingrese año de publicación: ");
                        int anio = int.Parse(Console.ReadLine());

                        titulos[contador] = titulo;
                        autores[contador] = autor;
                        anios[contador] = anio;
                        contador++;

                        Console.WriteLine("Libro registrado correctamente.\n");
                    }
                }

                else
                {
                    Console.WriteLine("No se pueden registrar más libros, capacidad máxima alcanzada.\n");
                }
            }

            // Opción 2: Mostrar Libros
            else if (opcion == 2)
            {
                if (contador == 0)
                {
                    Console.WriteLine("No hay libros registrados.\n");
                }
                else
                {
                    Console.WriteLine("\nLIBROS REGISTRADOS EN LA BIBLIOTECA:");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine("Título: " + titulos[i] + " | Autor: " + autores[i] + " | Año: " + anios[i]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }

}