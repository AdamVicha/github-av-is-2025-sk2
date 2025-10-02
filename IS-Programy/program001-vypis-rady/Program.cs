// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

/*int first;
int last;
int step;
bool loop = true;
Console.WriteLine("*****************************************");
Console.WriteLine("************Výpis číselné řady***********");
Console.WriteLine("*****************************************");
Console.WriteLine("****************Adam Vícha***************");
Console.WriteLine("****************2.10.2025****************");
Console.WriteLine("*****************************************");
Console.WriteLine("First: ");
first = int.Parse(Console.ReadLine());

Console.WriteLine("Last: ");
last = int.Parse(Console.ReadLine());

Console.WriteLine("Step: ");
step = int.Parse(Console.ReadLine());

Console.WriteLine("\n" + first);

while (loop)
{
    if ((first + step) <= last)
    {
        first = first + step;
        Console.WriteLine(first);
    }
    else
    {
        loop = false;
    }
}*/

﻿string again = "a";
while (again == "a")
{
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpis řady čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Adam Vícha *********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;

    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}