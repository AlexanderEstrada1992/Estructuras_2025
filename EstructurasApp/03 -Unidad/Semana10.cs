public class vacunas
{
    public static void run()
    {
        Random random = new Random();

         // Conjunto de 500 ciudadanos ficticios
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("persona" + i);
        }
    }

}