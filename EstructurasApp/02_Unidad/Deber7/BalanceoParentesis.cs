public class BalanceoParentesis
{
    // Verifico si los paréntesis, llaves y corchetes están balanceados
    public static void VerificarBalanceo(string expresion)
    {
        Stack<char> pila = new Stack<char>(); // Pila de caracteres
        bool balanceado = true;