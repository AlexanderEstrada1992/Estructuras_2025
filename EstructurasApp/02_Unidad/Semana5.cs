public class Semana5
{
    public static void run()
    {
        System.Console.WriteLine("  Ejercicio 1 - Asignaturas");
        System.Console.WriteLine("=============================");

        // Crear una colección de strings llamada asignaturas
        List<string> asignaturas = ["Matemáticas", "Física", "Química", "Historia", "Lengua"];

        // Imprimir la lista
        foreach (string asignatura in asignaturas)
        {
            System.Console.WriteLine(asignatura);
        }

        // Carátula ejercicio 2
        System.Console.WriteLine("  Ejercicio 2 - Asignaturas con mensaje");
        System.Console.WriteLine("=============================");

        // Crear una colección de strings llamada asignaturas con mensaje
        List<string> asignaturas con mensaje = ["Matemáticas", "Física", "Química", "Historia", "Lengua"];

        // Imprimir asignatura con mensaje
        foreach (string asignatura in asignaturas con mensaje)
        {
            System.Console.WriteLine($"Yo estudio {asignatura}");
        }

        // Carátula ejercicio 3
        System.Console.WriteLine("  Ejercicio 3 - Notas por Asignatura");
        System.Console.WriteLine("=============================");

        // Crear una colección de strings llamada asignaturas
        List<string> asignaturas = ["Matemáticas", "Física", "Química", "Historia", "Lengua"];
        List<double> notas = [];

        // Crear foreach
        foreach (string asignatura in asignaturas)
        {
            System.Console.Write($"Ingrese la nota de {asignatura}: ");
            double nota = Convert.ToDouble(Console.ReadLine());
            notas.Add(nota);
        }

        // Mostrar resultados
        for (int i = 0; i < asignaturas.Count; i++)
        {
            System.Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
        }

        // Carátula ejercicio 4
        System.Console.WriteLine("  Ejercicio 4 - Lotería");
        System.Console.WriteLine("=============================");

        // Crear lista númerosGanadores
        List<int> numerosGanadores = [];

        // Crear for
        System.Console.WriteLine("Ingrese 6 números ganadores de la lotería:");
        for (int i = 0; i < 6; i++)
        {
            System.Console.Write($"Número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numerosGanadores.Add(numero);
        }

        // Ordenar y mostrar
        numerosGanadores.Sort();
        System.Console.WriteLine("Números ganadores ordenados:");
        foreach (int numero in numerosGanadores)
        {
            System.Console.WriteLine(numero);
        }

        // Carátula ejercicio 5
        System.Console.WriteLine("  Ejercicio 5 - Números Inversos");
        System.Console.WriteLine("=============================");

        // Lista del 1 al 10
        List<int> numeros = [];

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Mostrar en orden inverso separados por comas
        numeros.Reverse();
        System.Console.WriteLine(string.Join(", ", numeros));
    }

}