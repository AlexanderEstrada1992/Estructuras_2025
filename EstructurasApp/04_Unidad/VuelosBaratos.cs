public class VuelosBaratos
{
    // Arreglo estático para almacenar vuelos
    static string[] origenes = new string[6];
    static string[] destinos = new string[6];
    static int[] precios = new int[6];

    public static void run()
    {
        // Creación de la base de datos ficticia
        origenes[0] = "Quito"; destinos[0] = "Guayaquil"; precios[0] = 60;
        origenes[1] = "Quito"; destinos[1] = "Cuenca"; precios[1] = 50;
        origenes[2] = "Quito"; destinos[2] = "Manta"; precios[2] = 45;
        origenes[3] = "Guayaquil"; destinos[3] = "Cuenca"; precios[3] = 40;
        origenes[4] = "Guayaquil"; destinos[4] = "Quito"; precios[4] = 55;
        origenes[5] = "Cuenca"; destinos[5] = "Manta"; precios[5] = 70;

        // Menú
        int opcion = 0;
        do
        {
            System.Console.WriteLine("\n--- MENÚ ---");
            System.Console.WriteLine("1. Mostrar todos los vuelos");
            System.Console.WriteLine("2. Buscar vuelos baratos desde una ciudad");
            System.Console.WriteLine("3. Salir");
            System.Console.Write("Ingrese una opción: ");
            opcion = int.Parse(System.Console.ReadLine());

            // Evaluar opción seleccionada
            switch (opcion)
            {
                case 1:
                    MostrarVuelos(); // Mostrar todos los vuelos
                    break;
                case 2:
                    System.Console.Write("Ingrese ciudad de origen: ");
                    string ciudad = System.Console.ReadLine();
                    BuscarVuelosBaratos(ciudad); // Buscar vuelos baratos desde la ciudad indicada
                    break;
                case 3:
                    System.Console.WriteLine("Saliendo..."); // Mensaje de salida
                    break;
                default:
                    System.Console.WriteLine("Opción inválida"); // Validación de opción
                    break;
            }

        } while (opcion != 3); // Mientras no sea 3, el menú sigue activo
    }
    
    // Método para mostrar todos los vuelos
    static void MostrarVuelos()
    {
        System.Console.WriteLine("\nLISTA DE VUELOS:");
        for (int i = 0; i < origenes.Length; i++)
        {
            // Imprimir cada vuelo con origen, destino y precio
            System.Console.WriteLine(origenes[i] + " -> " + destinos[i] + " | $" + precios[i]);
        }
    }

}