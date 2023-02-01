// See https://aka.ms/new-console-template for more information
//Test is in C:\Projetos\logicProgrammingTest\logicProgrammingTest\prova-logica-de-programacao.pdf

using logicProgrammingTest.Classes;
using System.Globalization;

Console.Write("Which is exercise do you wanna do it?\nIf you wanna see the file search by 'prova-logica-de-programacao.pdf'.\n");
var ex = int.Parse(Console.ReadLine().Trim());

switch (ex)
{
    case 1:
        Exercise1();
        break;
    case 2:
        Exercise2();
        break;

    case 3:
        Exercise3();
        break;

    case 32:
        Exercise3_2();
        break;

    default:
        //Exercise1();
        Test();
        break;
}

void Test()
{
    string a = null;

    var list = new List<string>() { 
        "alex", "test"
    };

    var b =list.Contains(a);

    Console.WriteLine(b);

}


#region  Sequential and Repetitive Structure 
void Exercise1()
{
    Console.WriteLine("How many products do you wanna register?");
    int loops = int.Parse(Console.ReadLine().Trim());

    int loopCount = 1;
    var products = new List<Product>();
    while (loops >= loopCount)
    {
        Console.WriteLine($" Tyoe: Code of product, Amount,  Unit price - {loopCount}: ");
        string str = Console.ReadLine();
        var array = str.Split(" ");

        int code = int.Parse(array[0]);
        int amount = int.Parse(array[1]);
        double unitPrice = double.Parse(array[2], CultureInfo.InvariantCulture);

        products.Add(new Product
        {
            Code = code,
            Amount = amount,
            Price = unitPrice
        });

        loopCount++;
    }

    double total = 0;
    products.ForEach(p => total += p.Amount * p.Price);

    Console.WriteLine($"You should pay ${total:F2}");
}
#endregion


#region Conditional structure (Baskara)
void Exercise2()
{
    Console.WriteLine($"Value of a:");
    var a = double.Parse(Console.ReadLine().Trim());

    Console.WriteLine($"Value of b:");
    var b = double.Parse(Console.ReadLine().Trim());

    Console.WriteLine($"Value of c:");
    var c = double.Parse(Console.ReadLine().Trim(), CultureInfo.InvariantCulture);

    //-b ±√∆
    //onde: ∆= b² − 4ac

    var delta = Math.Pow(b, 2) - (4 * a * c);
    if (a == 0)
    {
        Console.WriteLine($"Impossible to calculate.\na can't be 0");
        return;
    }

    if (delta <= 0)
    {
        Console.WriteLine($"Impossible to calculate.\nDelta can't be less than or equal to 0");
        return;
    }

    var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    var x2 = (-b - Math.Sqrt(delta)) / (2 * a);


    Console.WriteLine($"x1 = {x1}\nx2 = {x2}");

}
#endregion


#region Repetitive and Conditional Structure
void Exercise3()
{

    var input = "";
    var password = "2002";

    do
    {
        Console.WriteLine($"Password: ");
        input = Console.ReadLine();

        var message = input == password ? "Allowed Access" : "Invalid password, try again!";
        Console.WriteLine(message);

    } while (input != password);

}

void Exercise3_2()
{
    Console.Write($"How many numbers ?");
    var input = int.Parse(Console.ReadLine().Trim());

    var listIn = new List<int>();
    var listOut = new List<int>();

    for (int i = 0; i < input; i++)
    {
        Console.Write($"number: ");
        var number = int.Parse(Console.ReadLine().Trim());

        if (number >= 10 && number <= 20)
        {

            listIn.Add(number);
        }
        else
        {
            listOut.Add(number);

        }
    }

    Console.WriteLine($"{listIn.Count} in \n{listOut.Count} out");
}

#endregion