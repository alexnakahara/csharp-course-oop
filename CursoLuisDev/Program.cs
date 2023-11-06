// See https://aka.ms/new-console-template for more information
using CursoLuisDev;

Console.WriteLine("Hello, World!");
int num = 1;

double num2 = num; // conversão implicita
int convertExplicita = (int)num2; // conversão explicita


if (int.TryParse("", out int notaTryParse))
{
  System.Console.WriteLine("Consegui converter");
}
else
{
  System.Console.WriteLine("número inválido");
}

System.Console.WriteLine(notaTryParse);
int count = 0;

System.Console.WriteLine(count++);
System.Console.WriteLine(--count); // pre fixado executa antes da linha de codigo


var text = "Alexander Nakahara";
var sub = text.Substring(0, text.Length - 3);
var sub1 = text.Substring(2);
Console.WriteLine(sub);
Console.WriteLine(sub1);

#region OOP
Console.WriteLine("\n \n OOP");
var professor = new Professor(5000m, "João", "12345", new DateTime(1980, 1, 1));
var estudante = new Estudante("A", "Alexander", "50412351515", new DateTime(1999, 6, 10));

var pessoas = new List<Pessoa> { estudante, professor };

foreach (var pessoa in pessoas)
{
    pessoa.SeApresentar();
}

Console.Read();
#endregion