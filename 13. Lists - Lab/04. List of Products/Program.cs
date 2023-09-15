int productsCount = int.Parse(Console.ReadLine());

List<string> productsList = new List<string>();

for (int i = 0; i < productsCount; i++)
{
    productsList.Add(Console.ReadLine());
}

productsList.Sort();

for (int j = 1; j <= productsCount; j++)
{
    Console.WriteLine($"{j}.{productsList[j - 1]}");
}
