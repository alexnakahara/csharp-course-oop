// See https://aka.ms/new-console-template for more information

using OOP.Classes;
using System.Globalization;

bool isContinue = false;
do
{
    Console.WriteLine("Object-oriented programming (OOP).\nWhich is exercise do you wanna do it? ");
    int exercise = int.Parse(Console.ReadLine().Trim());

    switch (exercise)
    {
        case 1:
            GetTriangleArea(); break;
        case 2:
            GetProduct(); break;
        case 3:
            GetCircuferenceVolume(); break;
        case 4:
            OpenBankAccount(); break;
        case 5:
            Arrays(); break;
        case 6:
            ModifiersRefOut(); break;
        case 7:
            Lists(); break;
        case 8:
            MatrizFindDimensions(); break;
        default:
            //Exercise1();
            GetProductOOP();
            break;
    }

    Console.Write("\nDo you want continue executing the exercices? (y/n)\n");
    isContinue = Console.ReadLine().Trim().ToLower() == "y";
    Console.Clear();

} while (isContinue);

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
    var p2 = new Product { Name = name, Price = price, Amount = staffAmount }; // this way is possible because the class has a default constructor

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

#region Bank account
void OpenBankAccount()
{
    BankAccount account;

    Console.Write("Entre o número da conta: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Entre o titular da conta: ");
    string name = Console.ReadLine();

    Console.Write("Haverá depósito inicial (s/n)? ");
    bool hasInitDeposit = Console.ReadLine().ToUpper() == "S";

    if (hasInitDeposit)
    {
        Console.Write("Entre o valor de depósito inicial: ");
        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        account = new BankAccount(id, name, amount);
    }
    else
    {
        account = new BankAccount(id, name);
    }

    Console.Write(account.ToString());

    Console.Write("\nEntre um valor para depósito: ");
    account.DepositMoney(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
    Console.WriteLine(account.ToString());

    Console.Write("\nEntre um valor para saque: ");
    account.WithdrawMoney(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
    Console.Write(account.ToString());
}

#endregion

#region Class 6

void Arrays()
{
    var bedRoom = new Bedroom[10];

    Console.Write("How many students? ");
    var numStudents = int.Parse(Console.ReadLine());

    for (int i = 0; i < numStudents; i++)
    {
        Console.WriteLine();
        Console.Write("Which bedroom? ");
        var numBedroom = int.Parse(Console.ReadLine());

        Console.Write("Name? ");
        var name = Console.ReadLine();

        Console.Write("Email: ");
        var email = Console.ReadLine();

        Bedroom student = new(name, email);
        bedRoom[numBedroom] = student;
    }

    Console.WriteLine();
    Console.WriteLine("Quartos ocupados:");
    for (int i = 0; i < bedRoom.Length; i++)
    {
        if (bedRoom[i] != null)
            Console.WriteLine($"{i}: {bedRoom[i].StudentName}, {bedRoom[i].Email}");
    }
}

void ModifiersRefOut()
{
    int numRef = 5; // "ref" need init with value
    Calculator.TripleRef(ref numRef);
    Console.WriteLine($"Ref: {numRef}");

    int origin = 10;
    int triple; // "Out" doesnt need init just named
    Calculator.TripleOut(origin, out triple);
    Console.WriteLine($"Out: {triple}");
}

void Lists()
{
    List<string> list = new List<string>
    {
        "Alex",
        "James",
        "Nill",
        "Nick",
        "Anna",
        "Marco"
    };

    string s1 = list.Find(x => x[0] == 'A');
    Console.WriteLine("First 'A': " + s1);

    string s2 = list.FindLast(x => x[0] == 'A');
    Console.WriteLine("Last 'A': " + s2);

    Console.WriteLine("Find index");
    int pos1 = list.FindIndex(x => x[0] == 'A');
    Console.WriteLine("First position index 'A': " + pos1);

    int pos2 = list.FindLastIndex(x => x[0] == 'A');
    Console.WriteLine("Last position index 'A': " + pos2);

    Console.WriteLine();
    Console.WriteLine("Filtered List by Length = 5");
    List<string> list2 = list.FindAll(x => x.Length == 5);
    foreach (var item in list2)
    {
        Console.WriteLine(item);
    }

    list.Remove("James");
    Console.WriteLine("------------- Removing James");
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }

    list.RemoveAll(x => x[0] == 'A');
    Console.WriteLine("------------- Removing all items that has first letter 'A'");
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

void Matriz()
{
    double[,] mat = new double[2, 3];

    Console.WriteLine(mat.Length);
    Console.WriteLine("Gets first dimension: ", mat.Rank);
    Console.WriteLine("Linhas: ", mat.GetLength(0));
    Console.WriteLine("Colunas: ", mat.GetLength(1));
}
void MatrizFindDimensions()
{

    Console.Write("Coloque o numero de linhas: ");
    int lines = int.Parse(Console.ReadLine());

    Console.Write("Coloque o numero de colunas: ");
    int cols = int.Parse(Console.ReadLine());

    double[,] mat = new double[lines, cols];

    for (int i = 0; i < lines; i++)
    {
        Console.WriteLine($"Escreva os numeros da linha {i}: ");
        string[] arr = Console.ReadLine().Split(" ");

        for (int j = 0; j < cols; j++)
        {
            mat[i, j] = int.Parse(arr[j]);
        }
    }

    Console.WriteLine("\n------- show matriz ------\n");
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(mat[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.Write("Numero pra achar: ");
    int numFind = int.Parse(Console.ReadLine());
    Console.WriteLine();

    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            double item = mat[i, j];
            if (item == numFind)
            {
                double itemLeft, itemRight, itemUp, itemDown;

                Console.WriteLine($"Position {i},{j}:");
                if (j != 0) // it is not first column 
                {
                    itemLeft = mat[i, j - 1];
                    Console.WriteLine($"Left: {itemLeft}");
                }

                if (j != (mat.GetLength(1) - 1)) //last column
                {
                    itemRight = mat[i, j + 1];
                    Console.WriteLine("Right: " + itemRight);
                }

                if (i != 0) // it is not first line 
                {
                    itemUp= mat[i - 1, j];
                    Console.WriteLine("Up: " + itemUp);
                }

                if (i != (mat.GetLength(0) - 1)) // last line
                {
                    itemDown = mat[i + 1, j];
                    Console.WriteLine("Down: " + itemDown);
                }

            }
        }
        Console.WriteLine();
    }

}
#endregion