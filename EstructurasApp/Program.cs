// Carátula Tarea de la Semana 5
System.Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA");
System.Console.WriteLine("=============================");
System.Console.WriteLine();
System.Console.WriteLine("  Listas");
System.Console.WriteLine("=============================");




















// // Nombre del programa
// System.Console.WriteLine("Agenda Telefónica");
// System.Console.WriteLine("==================");

// // Definir el tamaño máximo del vector de contactos
// int max = 10;

// // Creación de un vector para almacenar los contactos
// Contacto[] agenda = new Contacto[max];

// // Crear tres contactos usando el constructor de la clase Contacto
// Contacto c1 = new Contacto("Alex Estrada", "0987654321", "alex@mail.com");
// Contacto c2 = new Contacto("María López", "0991234567", "maria@mail.com");
// Contacto c3 = new Contacto("Carlos Pérez", "0976543210", "carlos@mail.com");

// // Asignar los contactos al vector
// agenda[0] = c1;
// agenda[1] = c2;
// agenda[2] = c3;

// // Imprimir todos los contactos registrados
// bool continuar = true;
// int i = 0;
// while (continuar)
// {
//     if (agenda[i] != null) // Si hay un contacto en la posición i
//     {
//         Console.WriteLine("Nombre: " + agenda[i].Nombre +
//                           " | Teléfono: " + agenda[i].Telefono +
//                           " | Correo: " + agenda[i].Correo);
//         i++; // Avanzar al siguiente índice
//     }
//     else
//     {
//         continuar = false; // Terminar el ciclo si no hay más contactos
//     }
// }

// // Reiniciar valores para realizar una búsqueda
// continuar = true;
// bool encontrado = false;
// i = 0;

// // Nombre a buscar
// string consulta = "Alex Estrada";

// // Búsqueda de contacto por nombre
// while (continuar)
// {
//     if (agenda[i] != null)
//     {
//         if (agenda[i].Nombre == consulta)
//         {
//             encontrado = true; // Se encontró el contacto
//             Console.WriteLine("\nContacto encontrado: " + agenda[i].Nombre +
//                               " | Teléfono: " + agenda[i].Telefono +
//                               " | Correo: " + agenda[i].Correo);
//         }
//         i++;
//     }
//     else
//     {
//         continuar = false; // Terminar el ciclo si no hay más contactos
//     }
// }

// // Mostrar mensaje si no se encontró el contacto
// if (!encontrado)
// {
//     System.Console.WriteLine("\nEl contacto no existe.");
// }












// // Declarar e inicializar los datos del estudiante
// int id = 1;
// string nombres = "Juan";
// string apellidos = "Pérez";
// string direccion = "Calle Amazonas y Río Napo";

// // Crear un array de 3 teléfonos del estudiante
// string[] telefonos = new string[3];
// telefonos[0] = "0987654321";
// telefonos[1] = "022345678";
// telefonos[2] = "0934567890";

// // Crear un objeto de la clase Estudiante usando los datos
// Estudiante estudiante1 = new Estudiante(id, nombres, apellidos, direccion, telefonos);

// // Mostrar los datos del estudiante usando los métodos de la clase
// System.Console.WriteLine("ID: " + estudiante1.getId());
// System.Console.WriteLine("Nombres: " + estudiante1.getNombres());
// System.Console.WriteLine("Apellidos: " + estudiante1.getApellidos());
// System.Console.WriteLine("Dirección: " + estudiante1.getDireccion());

// // Mostrar los teléfonos uno por uno
// System.Console.WriteLine("Teléfonos:");
// string[] telfs = estudiante1.getTelefonos();
// System.Console.WriteLine("- " + telfs[0]);
// System.Console.WriteLine("- " + telfs[1]);
// System.Console.WriteLine("- " + telfs[2]);