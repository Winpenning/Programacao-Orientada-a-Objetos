using Problema1.Services;

Console.Write("How many values? ");
int values = int.Parse(Console.ReadLine());

PrintService<int> printService = new PrintService<int>();

for(int i = 1; i <= values; i++)
{
    int value = int.Parse(Console.ReadLine());
    printService.AddValue(value);
}

printService.Print();

Console.WriteLine("\nFirst: " + printService.First());