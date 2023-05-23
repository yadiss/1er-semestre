/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Programacion {
  static void Main() {
    
    double num1, num2, num3, total;
    Console.WriteLine("Dame un numero");
    num1=double.Parse(Console.ReadLine());
    Console.WriteLine("Dame otro numero");
    num2=double.Parse(Console.ReadLine());
    Console.WriteLine("Dame un tercer numero");
    num3=double.Parse(Console.ReadLine());
    total = (num1*num2*num3);
    Console.WriteLine($"El resultado de la multiplicacion de los tres factores es: {total}");
  }
}