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

        
    }

}