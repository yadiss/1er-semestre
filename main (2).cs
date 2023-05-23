/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
     int a=8;
    int b=3;
    int c=-5;
    Console.WriteLine(a+b+c);
    Console.WriteLine(2*b+3*(a-c));
    Console.WriteLine(a/b);
    Console.WriteLine($"d) {a % b}");
    Console.WriteLine($"e) {a/c}");
    Console.WriteLine($"f) {a % c}");
    Console.WriteLine($"g) {a*b/c}");
    Console.WriteLine(a*(b/c));
    Console.WriteLine((a+c)%b);
    Console.WriteLine(a*(c%b));
    Console.WriteLine(a* (b/c));
    Console.WriteLine(a* (c%b));
    Console.WriteLine(2* (a/5+ (4-b*3))%(a+c-2));
    Console.WriteLine(a-b-c*2);
  }
}