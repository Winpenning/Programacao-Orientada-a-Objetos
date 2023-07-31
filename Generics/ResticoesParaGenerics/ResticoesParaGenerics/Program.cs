using ResticoesParaGenerics.Entities;
using ResticoesParaGenerics.Services;

Console.Write("Enter N: ");
int _ = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();
CalculationService calculationService = new CalculationService();
for  (int i = 0; i < _; i++)
{
    string[] fields = Console.ReadLine().Split(',');

    string name = fields[0];
    double value =  Convert.ToDouble(fields[1]);
    products.Add(new Product(name, value));
}

Product p = calculationService.Max(products);

Console.WriteLine(p);