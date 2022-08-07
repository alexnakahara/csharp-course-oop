﻿// See https://aka.ms/new-console-template for more information

using OOP.Classes;
using System.Globalization;

Console.Write("Object-oriented programming (OOP).\nWhich is exercise do you wanna do it? ");
var ex = int.Parse(Console.ReadLine().Trim());

switch (ex)
{
    case 1:
        GetTriangleArea();
        break;
    case 2:
        GetProduct();
        break;

    case 3:
        GetCircuferenceVolume();
        break;

    default:
        //Exercise1();
        break;
}

// Exercises 

#region Triangle Area

void GetTriangleArea()
{
    Triangle x = new Triangle();
    Triangle y = new Triangle();

    Console.WriteLine("Entre com as medidas do triângulo X:");
    x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Entre com as medidas do triângulo Y:");
    y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double areaX = x.Area();
    double areaY = y.Area();
    Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
    Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

    if (areaX > areaY)
    {
        Console.WriteLine("Maior área: X");
    }
    else
    {
        Console.WriteLine("Maior área: Y");
    }



}
#endregion


#region Product

void GetProduct()
{
    var p = new Product();

    Console.WriteLine("Entre os dados do produto:");
    Console.Write("Nome: ");
    p.Name = Console.ReadLine();

    Console.Write("Preço: ");
    p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Quantidade no estoque: ");
    p.Amount = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Dados do produto: " + p);

    Console.WriteLine();
    Console.Write("Digite o número de produtos a ser adicionados ao estoque");
    int amount = int.Parse(Console.ReadLine());
    p.AddAmountProducts(amount);

    Console.WriteLine();
    Console.WriteLine("Dados atualiazados: " + p);

    Console.WriteLine();
    Console.Write("Digite o número de produtos a ser removidos do estoque");
    int amountRemove = int.Parse(Console.ReadLine());
    p.AddAmountProducts(amountRemove);

    Console.WriteLine();
    Console.WriteLine("Dados atualiazados: " + p);
}



#endregion


#region Calc(statics examples)

void GetCircuferenceVolume()
{
    Console.Write("Entre com o valor do raio: ");
    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double circ = Calculator.Circuference(raio);
    double volume = Calculator.Volume(raio);

    Console.WriteLine("Circunfêrencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Circunfêrencia: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
}

#endregion

