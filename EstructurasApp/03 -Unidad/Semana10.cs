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

        // Conjunto de vacunados con AstraZeneca (75 ciudadanos)
        HashSet<string> astrazeneca = new HashSet<string>();
        while (astrazeneca.Count < 75)
        {
            astrazeneca.Add("persona" + random.Next(1, 501));
        }

        // Ciudadanos con ambas dosis (Pfizer y AstraZeneca)
        HashSet<string> ambasDosis = new HashSet<string>();
        ambasDosis.UnionWith(pfizer);
        ambasDosis.IntersectWith(astrazeneca);
        
         // Ciudadanos que solo recibieron Pfizer
        HashSet<string> soloPfizer = new HashSet<string>();
        soloPfizer.UnionWith(pfizer);
        soloPfizer.ExceptWith(astrazeneca);
    }

}