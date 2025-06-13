public class Estudiante
{
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos;

    public Estudiante(int _id, string _nombres, string _apellidos, string _direccion, string[] _telefonos)
    {
        id = _id;
        nombres = _nombres;
        apellidos = _apellidos;
        direccion = _direccion;
        telefonos = _telefonos;
    }

    public int getId()
    {
        return id;
    }

    public string getNombres()
    {
        return nombres;
    }

    public string getApellidos()
    {
        return apellidos;
    }

    public string getDireccion()
    {
        return direccion;
    }

    public string[] getTelefonos()
    {
        return telefonos;
    }
}
