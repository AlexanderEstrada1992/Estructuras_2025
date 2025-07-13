public class BalanceoParentesis
{
    // Verifico si los paréntesis, llaves y corchetes están balanceados
    public static void VerificarBalanceo(string expresion)
    {
        Stack<char> pila = new Stack<char>(); // Pila de caracteres
        bool balanceado = true;

        // Recorremos cada caracter de la expresión
        foreach (char caracter in expresion)
        {
            // Si es un paréntesis de apertura, lo apilamos
            if (caracter == '(' || caracter == '{' || caracter == '[')
            {
                pila.Push(caracter);
            }
            // Si es un paréntesis de cierre
            else if (caracter == ')' || caracter == '}' || caracter == ']')
            {
                // Si la pila está vacía, hay un error
                if (pila.Count == 0)
                {
                    balanceado = false;
                    break;
                }

                char tope = pila.Pop(); // Extraemos el último abierto