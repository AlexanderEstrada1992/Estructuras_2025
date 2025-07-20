public class Parque
{
    public static void run()
    {
        // Creamos una cola vacía para almacenar los nombres de las personas
        Queue<string> personas = new Queue<string>();

        // Agregamos 30 personas a la cola en orden de llegada
        for (int i = 1; i <= 30; i++)
        {
            string nombrePersona = "Persona " + i;
            personas.Enqueue(nombrePersona); // Se agrega a la cola
        }

         // Mostramos el total de personas en la cola
        System.Console.WriteLine("Total de personas en la fila: " + personas.Count());
     }
}