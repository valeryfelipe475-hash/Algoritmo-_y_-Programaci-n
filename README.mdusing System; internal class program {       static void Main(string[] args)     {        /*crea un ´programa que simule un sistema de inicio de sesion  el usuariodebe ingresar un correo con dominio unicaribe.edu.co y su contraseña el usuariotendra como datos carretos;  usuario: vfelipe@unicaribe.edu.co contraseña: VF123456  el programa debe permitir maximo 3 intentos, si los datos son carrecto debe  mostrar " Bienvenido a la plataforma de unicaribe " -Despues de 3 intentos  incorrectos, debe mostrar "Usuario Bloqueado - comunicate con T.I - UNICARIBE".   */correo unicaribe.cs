using System;
internal class program { 

    static void Main(string[] args)
    { 
    

/*crea un ´programa que simule un sistema de inicio de sesion
 el usuariodebe ingresar un correo con dominio unicaribe.edu.co y su contraseña
el usuariotendra como datos carretos;

usuario: vfelipe@unicaribe.edu.co
contraseña: VF123456

el programa debe permitir maximo 3 intentos, si los datos son carrecto debe 
mostrar " Bienvenido a la plataforma de unicaribe "
-Despues de 3 intentos  incorrectos, debe mostrar
"Usuario Bloqueado - comunicate con T.I - UNICARIBE". 

*/
string correoCorrecto = "vfelipe@unicaribe.edu.co";
string passcorrecta= "vf123456";

    string email ="";
    string pass="";

        int intentos = 0;
    while (intentos < 3)
{ 
    Console.WriteLine("Ingrese su correo: ");
email = Console.ReadLine();

Console.WriteLine("Ingrese su contraseñana: ");
    pass = Console.ReadLine();

    if (email== correoCorrecto && pass == passcorrecta)
    {

        Console.WriteLine("Bienvenido a la plataforma de unicaribe");
                break;

    }else
{ 
    intentos++;
Console.WriteLine("Correo o contraseña  incorrecta");
Console.WriteLine(" Intento restantes : " + (3 - intentos));

}
if (intentos == 3)
{
    Console.WriteLine("usuario bloqueado - comunicate con T.I UNICARIBE");
}
}
}
}
