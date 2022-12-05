// See https://aka.ms/new-console-template for more information

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
        GetProductOOP();
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

    Console.WriteLine("Entre os dados do produto:");
    Console.Write("Nome: ");
    string name = Console.ReadLine();

    Console.Write("Preço: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Quantidade no estoque: ");
    int staffAmount = int.Parse(Console.ReadLine());
    
    var p = new Product(name, price, staffAmount);
    var p2 = new Product { Name= name, Price= price, Amount = staffAmount }; // this way is possible because the class has a default constructor

    Console.WriteLine();
    Console.WriteLine("Dados do produto: " + p);

    Console.WriteLine();
    Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
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


#region ProdutOop 
void GetProductOOP()
{
    ProductOop p = new ProductOop("TV", 500.00, 10);
    Console.WriteLine(p.Name);

    p.Name = "TV 4K"; // change name

    Console.WriteLine($"Name: {p.Name}\nPrice: {p.Price}"); 
}

#endregion
