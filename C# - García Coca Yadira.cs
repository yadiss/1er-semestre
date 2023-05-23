/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      /**Yadira García Coca
      Introducción a las TIC´s
      **/
    Console.WriteLine("Dime tu nombre");
    Console.WriteLine("Nombre: " + Console.ReadLine());
    Console.WriteLine("Dime tu número de control");
    string numeroControl = Console.ReadLine ();
    Console.WriteLine($"Tu número de control es {numeroControl}");
  }
}