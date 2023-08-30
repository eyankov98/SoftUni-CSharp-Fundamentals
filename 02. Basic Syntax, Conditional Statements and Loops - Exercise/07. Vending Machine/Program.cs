string command = Console.ReadLine();

double sum = 0;

while (command != "Start")
{
    double money = double.Parse(command);

    if (money != 0.1 && money != 0.2 && money != 0.5 && money != 1 && money != 2)
    {
        Console.WriteLine($"Cannot accept {money}");
    }
    else
    {
        sum = sum + money;
    }

    command = Console.ReadLine();
}

command = Console.ReadLine();

while (command != "End")
{
    if (command == "Nuts")
    {
        if (sum >= 2)
        {
            Console.WriteLine($"Purchased {command.ToLower()}");

            sum = sum - 2;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (command == "Water")
    {
        if (sum >= 0.7)
        {
            Console.WriteLine($"Purchased {command.ToLower()}");

            sum = sum - 0.7;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (command == "Crisps")
    {
        if (sum >= 1.5)
        {
            Console.WriteLine($"Purchased {command.ToLower()}");

            sum = sum - 1.5;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (command == "Soda")
    {
        if (sum >= 0.8)
        {
            Console.WriteLine($"Purchased {command.ToLower()}");

            sum = sum - 0.8;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (command == "Coke")
    {
        if (sum >= 1)
        {
            Console.WriteLine($"Purchased {command.ToLower()}");

            sum = sum - 1;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }

    command = Console.ReadLine();
}

Console.WriteLine($"Change: {sum:f2}");