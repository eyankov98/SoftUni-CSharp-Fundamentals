int n = int.Parse(Console.ReadLine());

int quantitiesOfWater = 0;

for (int i = 0; i < n; i++)
{
    int liters = int.Parse(Console.ReadLine());

    if (quantitiesOfWater + liters <= 255)
    {
        quantitiesOfWater = quantitiesOfWater + liters;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}

Console.WriteLine(quantitiesOfWater);