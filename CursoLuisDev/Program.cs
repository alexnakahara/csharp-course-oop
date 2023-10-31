// See https://aka.ms/new-console-template for more information
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
System.Console.WriteLine(sub);
System.Console.WriteLine(sub1);
