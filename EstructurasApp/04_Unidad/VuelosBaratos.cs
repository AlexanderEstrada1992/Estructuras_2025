public class VuelosBaratos
{
    // Arreglo de nodos (ciudades)
   static string[] ciudades = new string[4] { "Quito", "Guayaquil", "Cuenca", "Manta" };

    // Matriz de adyacencia para representar precios de vuelos entre ciudades
   
    static int[,] precios = new int[4,4]
    {
        { 0, 60, 50, 45 }, // Desde Quito a Quito, Guayaquil, Cuenca, Manta
        { 55, 0, 40, 0 },  // Desde Guayaquil a Quito, Guayaquil, Cuenca, Manta
        { 0, 0, 0, 70 },   // Desde Cuenca a Quito, Guayaquil, Cuenca, Manta
        { 0, 0, 0, 0 }     // Desde Manta a todas las ciudades (sin vuelos)
    };

    public static void run()
    {
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
            switch(opcion)
            {
                case 1:
                    MostrarVuelos();
                    break;
                case 2:
                    System.Console.Write("Ingrese ciudad de origen: ");
                    string ciudad = System.Console.ReadLine();
                    BuscarVuelosBaratos(ciudad);
                    break;
                case 3:
                    System.Console.WriteLine("Saliendo...");
                    break;
                default:
                    System.Console.WriteLine("Opción inválida");
                    break;
            }

        } while(opcion != 3);
    }

    // Método para mostrar todos los vuelos en forma de grafo
    static void MostrarVuelos()
    {
        System.Console.WriteLine("\nLISTA DE VUELOS:");
        for(int i = 0; i < ciudades.Length; i++)
        {
            for(int j = 0; j < ciudades.Length; j++)
            {
                if(precios[i,j] > 0)
                {
                    System.Console.WriteLine(ciudades[i] + " -> " + ciudades[j] + " | $" + precios[i,j]);
                }
            }
        }
    }
    
    // Método para buscar vuelos baratos desde una ciudad específica
    static void BuscarVuelosBaratos(string ciudad)
    {
        int index = -1;
        for(int i = 0; i < ciudades.Length; i++)
        {
            if(ciudades[i].ToLower() == ciudad.ToLower())
            {
                index = i;
                break;
            }
        }

        if(index == -1)
        {
            System.Console.WriteLine("Ciudad no encontrada.");
            return;
        }

        bool encontrado = false;
        System.Console.WriteLine("\nVuelos baratos desde " + ciudad + ":");

        for(int j = 0; j < ciudades.Length; j++)
        {
            if(precios[index,j] > 0 && precios[index,j] <= 55)
            {
                System.Console.WriteLine(ciudades[index] + " -> " + ciudades[j] + " | $" + precios[index,j]);
                encontrado = true;
            }
        }

        if(!encontrado)
            System.Console.WriteLine("No se encontraron vuelos baratos desde " + ciudad);
    }

}