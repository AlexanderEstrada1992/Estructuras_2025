public class Asignatura
{
    private string nombre;
    private double[] notas;

    // genero el constructor
    public Asignatura(string _nombre, double[] _notas)
    {
        nombre = _nombre;
        notas = new double[3];
        notas = _notas;
    }
    
    public string getAsigantura()
    {
        return nombre;
    }

    public double[] getNotas()
    {
        return notas;
    }
}