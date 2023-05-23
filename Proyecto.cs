/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(string[]args) {
    double mateCalif, eusCalif, prograCalif, inglesCalif, algeCalif;
    Console.WriteLine("Vamos a ver si hemos aprobado el curso");
    Console.WriteLine("Nota de matemáticas:");
    mateCalif = double.Parse (Console.ReadLine());
    Console.WriteLine("Nota de Euskera:");
    eusCalif = double.Parse (Console.ReadLine()) ;
    Console.WriteLine("Nota de Progrmación C#:");
    prograCalif = double.Parse (Console.ReadLine()) ;
    Console.WriteLine("Nota de inglés:");
    inglesCalif = double.Parse (Console.ReadLine()) ;
    Console.WriteLine("Nota de algebra:");
    algeCalif = double.Parse (Console.ReadLine()) ;
    double sumaNotas = mateCalif+eusCalif+prograCalif+inglesCalif+algeCalif;
    Console.WriteLine($"La suma de la calificaciones es: {sumaNotas}");
    double promNotas = sumaNotas/5 ;
    Console.WriteLine($"Su promedio es: {promNotas}");
    if (promNotas>=7)
     {
         Console.WriteLine("Aprobaste el curso");
     }
    else 
    {
        Console.WriteLine ("Reprobaste");
    }
  }
}