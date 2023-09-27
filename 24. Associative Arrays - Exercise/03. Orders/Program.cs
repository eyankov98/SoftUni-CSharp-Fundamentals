string info = string.Empty;

Dictionary<string, decimal> productsPrices = new Dictionary<string, decimal>();
Dictionary<string, decimal> productsQuantities = new Dictionary<string, decimal>();

while ((info = Console.ReadLine()) != "buy")
{
    string[] infoArray = info.Split();

    string productName = infoArray[0];
    decimal productPrice = decimal.Parse(infoArray[1]);
    int productCount = int.Parse(infoArray[2]);

    if (!productsQuantities.ContainsKey(productName))
    {
        productsQuantities.Add(productName, productCount);
    }
    else
    {
        productsQuantities[productName] += productCount;
    }

    if (!productsPrices.ContainsKey(productName))
    {
        productsPrices.Add(productName, productPrice * productCount);
    }
    else
    {
        productsPrices[productName] = productPrice * productsQuantities[productName];
    }
}

foreach (var product in productsPrices)
{
    Console.WriteLine($"{product.Key} -> {product.Value:f2}");
}