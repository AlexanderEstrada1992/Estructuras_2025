public class TorresDeHanoi
{
    // Método recursivo que resuelve el problema de las Torres de Hanoi
    public static void ResolverHanoi(int n, string origen, string destino, string auxiliar)
    {
        // Caso base: si solo hay un disco, lo movemos directamente
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 de {origen} a {destino}");
            return;
        }

        