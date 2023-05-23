/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[] numeros  = {45, 56, 2, -1, 98, 34};
    Console.WriteLine("Longitud: "+ numeros.Length);
    Console.WriteLine("Primer posición: "+ numeros[0]);
    Console.WriteLine("Última posición: "+ numeros[5]);
    Console.WriteLine("Penúltima posición: "+ numeros[4]);
    Console.WriteLine($"{numeros[0]}, {numeros[1]}, {numeros[2]}, {numeros[3]}, {numeros[4]}, {numeros[5]}");
    Console.WriteLine("============================================================");
    Array.Sort(numeros);
    Console.WriteLine($"Ordenado con Sort: {numeros[0]}, {numeros[1]}, {numeros[2]}, {numeros[3]}, {numeros[4]}, {numeros[5]}");
    numeros[0]=500;
    numeros[5]=-45;
    numeros[4]=37;
    Console.WriteLine($"Después de las modificaciones: {numeros[0]}, {numeros[1]}, {numeros[2]}, {numeros[3]}, {numeros[4]}, {numeros[5]}");
    Array.Sort(numeros);
    Console.WriteLine($"Ordenado con Sort: {numeros[0]}, {numeros[1]}, {numeros[2]}, {numeros[3]}, {numeros[4]}, {numeros[5]}");
    Console.WriteLine("============================================================");
    Array.Reverse(numeros);
    Console.WriteLine($"Revertir orden: {numeros[0]}, {numeros[1]}, {numeros[2]}, {numeros[3]}, {numeros[4]}, {numeros[5]}");
  }
}