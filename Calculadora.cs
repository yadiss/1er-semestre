/********************************
Integrantes:
Ruby Mora Solis
Ari Sebastián Pérez Hernández
Claudia Alejandra Becerra Carreto
Yadira García Coca
T5
*********************************/
using System;
class HelloWorld {
  static void Main() {
    //Yadira García Coca T5//
    double numeroUno, numeroDos;
    Console.WriteLine ("===========================================");
    Console.WriteLine ("\t\tCalculadora");
    Console.WriteLine ("===========================================");
    Console.WriteLine ("Selecciona que operación quieres realizar");
    Console.WriteLine ("1) Suma");
    Console.WriteLine ("2) Resta");
    Console.WriteLine ("3) Multiplicación");
    Console.WriteLine ("4) División");
    Console.WriteLine ("5) Potencia");
    Console.WriteLine ("Escribe el primer número");
    numeroUno = double.Parse (Console.ReadLine());
    Console.WriteLine ("Escribe el segundo número");
    numeroDos = double.Parse (Console.ReadLine());
    Console.WriteLine ("Escribe el número de operación que quieras realizar");
    int opcion = int.Parse(Console.ReadLine());
    int option = opcion;
    switch (option)
    {
        case 1:
            double resultadoSuma = (numeroUno + numeroDos);
            Console.WriteLine ($"El resultado es: {resultadoSuma}");
            break;
        case 2:
            double resultadoResta =  (numeroUno - numeroDos);
            Console.WriteLine ($"El resultado es: {resultadoResta}");
            break;
        case 3:
            double resultadoMulti =  (numeroUno * numeroDos);
            Console.WriteLine ($"El resultado es: {resultadoMulti}");
            break;
        case 4:
            double resultadoDivi =  (numeroUno / numeroDos);
            Console.WriteLine ($"El resultado es: {resultadoDivi}");
            break;
        case 5:
            double resultadoPotencia = Math.Pow(numeroUno, numeroDos);
            Console.WriteLine ($"El resultado es: {resultadoPotencia}");
            break;
        default:
            Console.WriteLine ("Error");
            break;
    }
  }
}