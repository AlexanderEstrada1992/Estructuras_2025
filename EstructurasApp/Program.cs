Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
Console.WriteLine("=============================");
Console.WriteLine();

System.Console.WriteLine("el perímtro de un cuadrado de lado 5 es " + perímetroCuadrado(5));
System.Console.WriteLine("el área de un cuadrado de lado 5 es " + areaCuadrado(5));


// Función para calcular el perímetro de un cuadrado o rectángulo
double perímetroCuadrado(double lado)
{
    return lado + lado + lado + lado;
}
double areaCuadrado(double lado)
{
    return lado * lado;
}