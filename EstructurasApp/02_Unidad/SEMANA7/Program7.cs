public class Program7
{
    public static void run()
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Encabezado institucional
                Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
                Console.WriteLine("=============================");
                Console.WriteLine();

                // Verificación de paréntesis balanceados
                Console.WriteLine("\nVerificación de paréntesis:");
                string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
                BalanceoParentesis.VerificarBalanceo(expresion);
                
                // Solución al problema de las Torres de Hanoi
                Console.WriteLine("\nResolución Torres de Hanoi:");
                int numDiscos = 3; // Número de discos a mover
                TorresDeHanoi.ResolverHanoi(numDiscos, "A", "C", "B");
            }
        }
    }

}