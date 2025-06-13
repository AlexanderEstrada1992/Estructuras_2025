// Clase Estudiante para almacenar la información personal de un estudiante
public class Estudiante
{
    // Atributos privados del estudiante
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos; // Array para guardar 3 teléfonos

    // Constructor que recibe los datos y los asigna a los atributos
    public Estudiante(int _id, string _nombres, string _apellidos, string _direccion, string[] _telefonos)
    {
        id = _id;
        nombres = _nombres;
        apellidos = _apellidos;
        direccion = _direccion;
        telefonos = _telefonos;
    }

    // Método para obtener el ID
    public int getId()
    {
        return id;
    }

    // Método para obtener los nombres
    public string getNombres()
    {
        return nombres;
    }

    // Método para obtener los apellidos
    public string getApellidos()
    {
        return apellidos;
    }

    // Método para obtener la dirección
    public string getDireccion()
    {
        return direccion;
    }

    // Método para obtener el array de teléfonos
    public string[] getTelefonos()
    {
        return telefonos;
    }
}