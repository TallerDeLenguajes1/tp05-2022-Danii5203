﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;

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