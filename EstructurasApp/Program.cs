System.Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
System.Console.WriteLine("=============================");
System.Console.WriteLine("REGISTRO DE ESTUDIANTE");
System.Console.WriteLine();

int id = 1;
string nombres = "Juan";
string apellidos = "Pérez";
string direccion = "Calle Amazonas y Río Napo";

string[] telefonos = new string[3];
telefonos[0] = "0987654321";
telefonos[1] = "022345678";
telefonos[2] = "0934567890";

Estudiante estudiante1 = new Estudiante(id, nombres, apellidos, direccion, telefonos);

System.Console.WriteLine("ID: " + estudiante1.getId());
System.Console.WriteLine("Nombres: " + estudiante1.getNombres());
System.Console.WriteLine("Apellidos: " + estudiante1.getApellidos());
System.Console.WriteLine("Dirección: " + estudiante1.getDireccion());

System.Console.WriteLine("Teléfonos:");
string[] telfs = estudiante1.getTelefonos();
System.Console.WriteLine("- " + telfs[0]);
System.Console.WriteLine("- " + telfs[1]);
System.Console.WriteLine("- " + telfs[2]);
