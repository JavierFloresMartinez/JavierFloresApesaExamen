// See https://aka.ms/new-console-template for more information
using BL;

Console.WriteLine("Hello, World!");


ML.Result resultado= new ML.Result();

ML.Usuario usuario = new ML.Usuario();
usuario.Usuarios = new List<object>();

int op;
do
{
    Console.WriteLine("Seleccione una opcion");
    Console.WriteLine("1. Agregar");
    Console.WriteLine("2. Visualizar");
    Console.WriteLine("3. Salir");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("Opcion 1: Agregar");
            Console.WriteLine("Ingrese nombre completo");
            usuario.NombreCompleto = Console.ReadLine();
            Console.WriteLine("Ingrese Fecha de nacimiento  dd/mm/yyyy");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese correo electronico");
            usuario.CorreoElectronico = Console.ReadLine();
            ML.Result result = BL.Usuario.Add(usuario);
            if (result.Correct)
            {
                usuario.Usuarios.Add(result.Object);
               
            }
            break;
        case 2:
            Console.WriteLine("Opcion 2: Visualizar");
            foreach (ML.Usuario usuario1 in usuario.Usuarios)
            {
                Console.WriteLine("Nombre Completo: " + usuario1.NombreCompleto);
                Console.WriteLine("Fecha de nacimiento: " + usuario1.FechaNacimiento);
                Console.WriteLine("Correo Electronico: " + usuario1.CorreoElectronico);
                Console.WriteLine("");
                Console.WriteLine("");
            }
            break;
        default:
            Console.WriteLine("Opcion incorrecta, Ingrese una opcion correcta");
            break;
    }
    

    
} while (op != 3);

Console.ReadKey();