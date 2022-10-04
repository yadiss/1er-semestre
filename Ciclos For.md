using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Ciclo FOR");
    Console.WriteLine("Vamos a imprimir el número que quieras hasta el 15");
    Console.WriteLine("Dime en qué número quieres empezar");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine("Dime en qué cantidades quieres avanzar");
    int aumento = int.Parse(Console.ReadLine());
    Console.WriteLine("Aquí están los números:");
    for (i=i; i<15; i=i+aumento)
    {
        Console.WriteLine(i);
    }
  }
}
