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
    }
}



//Semana5.run();
//Semana4.run();
//EjemploAgenda.run();
//Agenda.run();
//Deber6.run();
//pilas.run();























