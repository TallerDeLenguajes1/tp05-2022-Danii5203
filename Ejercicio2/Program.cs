// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;

string otroCalculo = String.Empty;

do
{
    //elegimos la operacion a realizar
    Console.WriteLine("Que operacion desea realizar?\n1-Suma\n2-Resta\n3-Multiplicacion\n4-Division\nRespuesta: ");   
    int opcionAritmetica = Convert.ToInt32(Console.ReadLine());
    double resultado = 0;

    //pedimos los valores
    Console.WriteLine("Ingrese el primer valor: ");
    double n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo valor: ");
    double n2 = Convert.ToDouble(Console.ReadLine());

    switch (opcionAritmetica)
    {
        case 1:
            resultado = suma(n1, n2);
            break;
        case 2:
            resultado = resta(n1, n2);
            break;
        case 3:
            resultado = multiplicacion(n1, n2);
            break;
        case 4:
            resultado = division(n1, n2);
            break;
        default:
            Console.WriteLine("Ingreso un valor incorrecto!");
            break;
    }
    Console.WriteLine("Resultado = "+resultado);
    Console.WriteLine("-------------------------------------------------------------------");
    Console.WriteLine("Desea realizar otra operacion?\nSI/si o NO/no\nRespuesta: ");
    otroCalculo = Console.ReadLine();
} while (otroCalculo != "no" && otroCalculo != "NO");

//funciones calculadora V1
double suma(double n1, double n2){
    return n1+n2;   
}
double resta(double n1, double n2){
    return n1-n2;
}
double multiplicacion(double n1, double n2){
    return n1*n2;
}
double division(double n1, double n2){
    return n1/n2;
}