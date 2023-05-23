/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

Claudia Alejandra Becerra Carreto
Ari Sebastian Perez Hernandez
Yadira Garcia Coca
Ruby Mora Solis

*******************************************************************************/
using System;
class examen {
  static void Main() {
    
    Console.WriteLine("Introduzca el primer texto");
    string text1 =Console.ReadLine();
    Console.WriteLine("Introduzca el segundo texto");
    string text2 =Console.ReadLine();
    Console.WriteLine("Introduzca el tercer texto");
    string text3 =Console.ReadLine();
    Console.WriteLine("Resultado de los tres textos y añadidos con salto de linea");
    Console.WriteLine($"{text1} \n{text2} \n{text3}"); 
    
  }
}