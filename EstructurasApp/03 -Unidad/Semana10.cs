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

        // Ciudadanos que solo recibieron AstraZeneca
        HashSet<string> soloAstrazeneca = new HashSet<string>();
        soloAstrazeneca.UnionWith(astrazeneca);
        soloAstrazeneca.ExceptWith(pfizer);

        // Ciudadanos que no se han vacunado
        HashSet<string> noVacunados = new HashSet<string>();
        noVacunados.UnionWith(ciudadanos);
        noVacunados.ExceptWith(pfizer);
        noVacunados.ExceptWith(astrazeneca);
        
        // Resultados
        Console.WriteLine("Resultados de la campaña de vacunación");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        Console.WriteLine("Total de ciudadanos: " + ciudadanos.Count);
        Console.WriteLine("Vacunados con Pfizer: " + pfizer.Count);
        Console.WriteLine("Vacunados con AstraZeneca: " + astrazeneca.Count);
        Console.WriteLine("Ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Solo AstraZeneca: " + soloAstrazeneca.Count);
        Console.WriteLine("No vacunados: " + noVacunados.Count);
        Console.WriteLine();
    }

}