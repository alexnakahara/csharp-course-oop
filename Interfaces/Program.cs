using Interfaces.Entities;
using Interfaces.Entities.Contract;
using Interfaces.Entities.InheritanceWithInterface;
using Interfaces.Entities.InheritanceWithInterface.Enums;
using Interfaces.Services;
using System.Globalization;

Console.Write("Put the number method to execute: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1: RentCar(); break;

    case 2: ContractInstallments(); break;   
    case 3: InheritanceWithInterface(); break;
    case 4: CompareInterface(); break;
}

void CompareInterface ()
{
    string path = @"C:\Projetos\csharp-course-oop\interfaces\Assets\in.txt";

    try
    {
        using (StreamReader sr = File.OpenText(path))
        {
            var list = new List<Employee>();
            while (!sr.EndOfStream)
            {
                list.Add(new Employee(sr.ReadLine()));
            }

            list.Sort();
            foreach(Employee item in list) {
                Console.WriteLine(item);
            }

        }

    }
    catch (IOException e)
    {
        Console.WriteLine("An error occurred");
        Console.WriteLine(e.Message);
    }
}

void InheritanceWithInterface()
{
    IShape s1 = new Circle()
    {
        Radius = 2,
        Color = Color.White
    };
    
    IShape s2 = new Rectangle()
    {
        Width = 3.5,
        Height = 4.2,
        Color = Color.Black
    };

    Console.WriteLine(s1);
    Console.WriteLine(s2);


}

void RentCar()
{
    Console.WriteLine("Enter rental data:");
    Console.Write("Car Model: ");
    string model = Console.ReadLine();

    Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
    DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

    Console.Write("Return (dd/MM/yyyy hh:mm): ");
    DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

    Console.Write("Enter price per hour: ");
    double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Enter price per day: ");
    double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    CarRental carRental = new(start, finish, new Vehicle(model));

    RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
    rentalService.ProcessInvoice(carRental);

    Console.WriteLine("INVOICE");
    Console.WriteLine(carRental.Invoice);
}


void ContractInstallments()
{
    Console.WriteLine("Enter contract data");
    Console.Write("Number: ");
    int num = int.Parse(Console.ReadLine());

    Console.Write("Data (dd/MM/yyyy): ");
    var date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    Console.Write("Contract value: ");
    double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Enter number of installments: ");
    int numberInstallments = int.Parse(Console.ReadLine());

    var contract = new Contract(num, date, totalValue);
    var service = new ContractService(new PaypalService());
    service.ProcessPayment(contract, numberInstallments);

    Console.WriteLine();
    Console.WriteLine("INSTALLMENTS");
    foreach (var item in contract.Installments)
    {
        Console.WriteLine(item.ToString());
    }
}