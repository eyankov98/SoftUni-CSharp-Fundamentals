string input = Console.ReadLine();

List<Box> boxes = new List<Box>();

while (input != "end")
{
    string[] infoAsArray = input.Split(" ").ToArray();

    string serialNumber = infoAsArray[0];
    string itemName = infoAsArray[1];
    int itemQuantity = int.Parse(infoAsArray[2]);
    decimal itemPrice = decimal.Parse(infoAsArray[3]);

    Item item = new Item
    {
        Name = itemName,
        Price = itemPrice,
    };

    Box box = new Box
    {
        SerialNumber = serialNumber,
        Item = item,
        ItemQuantity = itemQuantity,
        PriceforBox = itemQuantity * itemPrice,
    };

    boxes.Add(box);

    input = Console.ReadLine();
}

foreach (var box in boxes.OrderByDescending(x => x.PriceforBox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceforBox:f2}");
}
class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceforBox { get; set; }
}
class Item
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}