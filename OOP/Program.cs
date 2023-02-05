using OOP.Classes;
using OOP.Classes.AbstractShape;
using OOP.Classes.Employee;
using OOP.Classes.Entities;
using OOP.Classes.Generics;
using OOP.Classes.OrderTicket;
using OOP.Classes.SocialMediaLikes;
using System.Globalization;
using Color = OOP.Classes.AbstractShape.Enums.Color;

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
        case 9:
            EnumWorkers(); break;
        case 10:
            SocialMediaLikes(); break;
        case 11:
            GetPayEmployee(); break;
        case 12:
            GetTotalPrice(); break;
        case 13:
            ManageFile(); break;
        case 14:
            AbstractShape(); break;
        case 15:
            PrintGenerics(); break;
        default:
            //Exercise1();
            //GetProductOOP();
            //OrderChallenge();
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
                    itemUp = mat[i - 1, j];
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

#region Class 9

void OrderEnum()
{
    Order order = new() { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };
    Console.WriteLine(order);

    string txt = OrderStatus.PendingPayment.ToString();
    Console.WriteLine(txt);

    OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
    Console.WriteLine(os);
}

void EnumWorkers()
{
    Console.Write("Enter department's name: ");
    string deptName = Console.ReadLine();
    Console.WriteLine("Enter worker data:");

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Level (Junior/MidLevel/Senior)");
    var level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

    Console.Write("Base Salary");
    double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Department dept = new Department(deptName);
    Worker worker = new Worker(name, level, baseSalary, dept);

    Console.Write("How many contracts to this worker? ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Enter #{i + 1} contract data: ");
        Console.Write("Date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Duration (hours): ");
        int hours = int.Parse(Console.ReadLine());

        HourContract contract = new HourContract(date, valuePerHour, hours);
        worker.AddContract(contract);
    }

    Console.WriteLine();
    Console.Write("Enter month and year to calculate income (MM/YY): ");
    string monthAndYear = Console.ReadLine();
    int month = int.Parse(monthAndYear.Substring(0, 2));
    int year = int.Parse(monthAndYear.Substring(3));

    Console.WriteLine("Name: " + worker.Name);
    Console.WriteLine("Department: " + worker.Department.Name);
    Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
}

void SocialMediaLikes()
{
    Comment c1 = new Comment("Have a nice trip!");
    Comment c2 = new Comment("Wow that's awesome");

    Post p1 = new(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm goint to visit this wonderful country", 12);
    p1.AddComment(c1);
    p1.AddComment(c2);

    Console.WriteLine(p1);

}

void OrderChallenge()
{

    Console.WriteLine("Enter cliente data:");
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("E-mail: ");
    string email = Console.ReadLine();

    Console.Write("Birth date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Enter order data:");
    Console.Write("Status: ");
    var status = (OOP.Classes.OrderChallenge.OrderStatusEnum)Enum.Parse(typeof(OOP.Classes.OrderChallenge.OrderStatusEnum), Console.ReadLine());

    var client = new OOP.Classes.OrderChallenge.Client(name, email, date);
    var order = new OOP.Classes.OrderChallenge.Order(DateTime.Now, status, client);

    Console.Write("How many items to this order? ");
    int numOrders = int.Parse(Console.ReadLine());

    for (int i = 0; i < numOrders; i++)
    {
        Console.WriteLine($"Enter #{i + 1} item data:");

        Console.Write("Product Name: ");
        string productName = Console.ReadLine();

        Console.Write("Product price: ");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        OOP.Classes.OrderChallenge.ProductItem product = new OOP.Classes.OrderChallenge.ProductItem(productName, price);
        order.Items.Add(new OOP.Classes.OrderChallenge.OrderItem(quantity, product));
    }


    Console.WriteLine(order);

}


#endregion

#region Class 10(Inheritance, Polymorphism and Casting)

void GetPayEmployee()
{
    var list = new List<Employee>();

    Console.Write("Enter the number of employee: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Employee #{i + 1} data:");

        Console.Write("Outsourced (y/n)? ");
        char ch = char.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Value per Hour: ");
        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (ch == 'y')
        {
            Console.Write("Additional charge: ");
            double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
        }
        else
        {
            list.Add(new Employee(name, hours, valuePerHour));
        }
    }

    Console.WriteLine();
    Console.WriteLine("Payments:");

    foreach (Employee item in list)
    {
        Console.WriteLine(item.Name + " - $" + item.Payment().ToString("F2", CultureInfo.InvariantCulture));
    }
}

void GetTotalPrice()
{
    var list = new List<ProductTicket>();
    Console.Write("Enter the number of products: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Product #{i + 1} data:");
        Console.Write("Common, used or imported (c/u/i)? ");
        char model = char.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (model == 'i')
        {
            Console.Write("Customs fee: ");
            double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            list.Add(new ImportedProduct(name, price, customsFee));
        }
        else if (model == 'u')
        {
            Console.Write("Manufacture date (DD/MM/YYYY): ");
            var manuFac = DateTime.Parse(Console.ReadLine());

            list.Add(new UsedProduct(name, price, manuFac));
        }
        else
        {
            list.Add(new ProductTicket(name, price));
        }
    }

    Console.WriteLine();
    Console.WriteLine("PRICE TAGS:");

    foreach (ProductTicket item in list)
    {
        Console.WriteLine(item.PriceTag());
    }
}

void AbstractShape()
{
    var list = new List<Shape>();

    Console.Write("Enter the number of shapes: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Shape #{i + 1} data:");

        Console.Write("Rectangle or Circle (r/c)? ");
        char ch = char.Parse(Console.ReadLine());

        Console.Write("Color (Black/Blue/Red)");
        var color = Enum.Parse<Color>(Console.ReadLine());

        if (ch == 'r')
        {
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            list.Add(new Retangle(width, height, color));
        }
        else
        {
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            list.Add(new Circle(radius, color));
        }
    }

    Console.WriteLine();
    Console.WriteLine("SHAPE AREAS: ");

    foreach (Shape shape in list)
    {
        Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
    }
}

void ManageFile()
{
    string path = @"C:\Projetos\csharp-course-oop\myfolder\Produtos\lista.csv";

    try
    {

        using FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
        using StreamReader sr = new StreamReader(fs);
        var listProducts = new List<Product>();
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(",");
            listProducts.Add(new Product(line[0], double.Parse(line[1], CultureInfo.InvariantCulture), int.Parse(line[2])));
        }

        string newfolderPath = Path.GetDirectoryName(path) + @"\out";
        Directory.CreateDirectory(newfolderPath);

        using StreamWriter sw = File.AppendText(newfolderPath + @"\summary.csv");
        foreach (var item in listProducts)
        {
            sw.WriteLine(item.ToString());
        }


    }
    catch (IOException e)
    {

        Console.WriteLine("An error occured");
        Console.WriteLine(e.Message);
    }
}
#endregion

#region Class 14 Generics

void PrintGenerics()
{
    var printService = new PrintService<int>();

    Console.Write("How many values? ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        int x = int.Parse(Console.ReadLine());
        printService.AddValue(x);
    }

    printService.Print();
    Console.WriteLine($"\nFirst: {printService.First()}");


    Console.WriteLine("\n--------- Using Generics w/ strings ----------\n");

    var printService2 = new PrintService<string>();

    Console.Write("How many values? ");
    int n2 = int.Parse(Console.ReadLine());

    for (int i = 0; i < n2; i++)
    {
        string x = Console.ReadLine();
        printService2.AddValue(x);
    }

    printService2.Print();
    Console.WriteLine($"\nFirst: {printService2.First()}");

}
#endregion
