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
        
        // Empezamos a asignar asientos en orden de llegada
        int asiento = 1;
        while (personas.Count() > 0)
        {
            string persona = personas.Dequeue(); // Se atiende a la primera persona de la cola
            System.Console.WriteLine(persona + " ha ocupado el asiento número " + asiento);
            asiento++; // Pasamos al siguiente asiento

            System.Console.WriteLine("Todos los asientos han sido ocupados.");
        }
     }
}