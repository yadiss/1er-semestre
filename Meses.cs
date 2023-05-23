/******************************************************************************

Ruby Mora Solis
Claudia Alejandra Becerra Carreto
Ari Sebastián Pérez Hernández
Yadira García Coca
T5

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine ("Escribe el número del mes que quieres saber cuántos días tiene");
    int mes = int.Parse(Console.ReadLine());
    if (mes==1 || mes==3 || mes==5 || mes==7 || mes==8 || mes==10 || mes==12)
    Console.WriteLine("Este mes tiene 31 días");
    if (mes==2){
        Console.WriteLine("Escribe el año");
        int año = int.Parse(Console.ReadLine());
        int bisiesto = año % 4;
       if (bisiesto==0)
       Console.WriteLine("Tiene 29 días");
       else
       Console.WriteLine("Tiene 28 días");
    }
    if (mes==4|| mes==6 || mes==9 || mes==11)
    Console.WriteLine("Este mes tiene 30 días");
  }
}