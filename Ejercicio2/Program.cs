// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Hello, World!");


//version 2
Console.WriteLine("Ingrese un valor: ");
double n3 = Convert.ToDouble(Console.ReadLine());

//funciones calculadora V2
Console.WriteLine("El valor absoluto de "+n3+" = "+Math.Abs(n3));
Console.WriteLine("El cuadrado de "+n3+" = "+Math.Pow(n3, 2));
Console.WriteLine("La raiz cuadrada de "+n3+" = "+Math.Sqrt(n3));
Console.WriteLine("El Seno de "+n3+" = "+Math.Sin(n3));
Console.WriteLine("El Coseno de "+n3+" = "+Math.Cos(n3));
Console.WriteLine("Redondeo el numero flotante "+n3+" = "+Math.Round(n3));

Console.WriteLine("Ingrese un primer valor: ");
double valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese un segundo valor: ");
double valor2 = Convert.ToDouble(Console.ReadLine());

if(valor1 > valor2){
    Console.WriteLine("El valor maximo (valor 1): "+ valor1);
    Console.WriteLine("El valor minimo (valor 2): "+ valor2);
}else{
    if(valor2 > valor1){
        Console.WriteLine("El valor maximo (valor 2): "+ valor2);
        Console.WriteLine("El valor minimo (valor 1): "+ valor1);
    }else{
        Console.WriteLine(valor1+"(valor 1) es igual a "+valor2+"(valor 2).");
    }
}