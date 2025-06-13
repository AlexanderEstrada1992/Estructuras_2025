Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
Console.WriteLine("=============================");
Console.WriteLine();

Cuadrado mi_cuadrado = new Cuadrado(4);
System.Console.WriteLine("El área del cuadrado es: " + mi_cuadrado.area());
System.Console.WriteLine();

Asignatura matemáticas = new Asignatura("matematicas", [12, 13, 18]);

System.Console.WriteLine(matemáticas.getAsignatura());
System.Console.WriteLine(matemáticas.getNotas());

double[] minotas = matemáticas.getNotas();
System.Console.WriteLine(minotas[0]);
System.Console.WriteLine(minotas[1]);
System.Console.WriteLine(minotas[2]);