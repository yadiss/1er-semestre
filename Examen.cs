/***********************************************************************************************************

Claudia Alejandra Becerra Carreto
Ari Sebastián Pérez Hernández
Ruby Mora Solis
Yadira García Coca

***********************************************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Escribe el nombre de usuario:");
    string usuario = Console.ReadLine();
    Console.WriteLine("Introduce la contraseña:");
    string contraseña = Console.ReadLine();
    if (usuario=="masterdevs" && contraseña=="12345678")
    {
        Console.WriteLine("Sesión iniciada correctamente");
    }
    else
    {
     Console.WriteLine("Inicio de sesión incorrecta");
    }
}
}