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

        // Conjunto de vacunados con Pfizer (75 ciudadanos)
        HashSet<string> pfizer = new HashSet<string>();
        while (pfizer.Count < 75)
        {
            pfizer.Add("persona" + random.Next(1, 501));
        }
        
        
    }

}