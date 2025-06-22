// Definición de la clase Contacto que representa un registro
public class Contacto
{
    // Propiedades del contacto
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }

    // Creación del Constructor 
    public Contacto(string _nombre, string _telefono, string _correo)
    {
        Nombre = _nombre;
        Telefono = _telefono;
        Correo = _correo;
    }
}