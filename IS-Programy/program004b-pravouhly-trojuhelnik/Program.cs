string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("***** Vykreslení trojuhelniku *****");
    Console.WriteLine("***********************************");
    Console.WriteLine("*********** Adam Vícha ************");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    Console.Write("Zadejte výšku trojúhelníku: ");
    int vyska;

    while (!int.TryParse(Console.ReadLine(), out vyska) || vyska <= 0)
    {
        Console.Write("Zadejte prosím kladné celé číslo: ");
    }

    Console.WriteLine("\nPravoúhlý trojúhelník:\n");

    for (int i = 1; i <= vyska; i++)
    {
       for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150));
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}