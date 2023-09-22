string inputCoins=Console.ReadLine();
double change = 0;
while (inputCoins !="Start")
{//· 0.1, 0.2, 0.5, 1 and 2
    double coins=double.Parse(inputCoins);
    if (coins==0.1)
    { change += 0.1; }
    else if (coins == 0.2)
    { change += 0.2; }
    else if(coins == 0.5)
    { change += 0.5; }
    else if(coins == 1)
    { change += 1; }
    else if (coins == 2)
    { change += 2; }
    else { Console.WriteLine($"Cannot accept {coins}"); }
    inputCoins = Console.ReadLine();
}
string product=Console.ReadLine();

while(product !="End")
{
    /*· "Nuts" with a price of 2.0

· "Water" with a price of 0.7

· "Crisps" with a price of 1.5

· "Soda" with a price of 0.8

· "Coke" with a price of 1.0*/
    if (product== "Nuts")
    { if (change>=2.0)
        { change -= 2.0;
            Console.WriteLine($"Purchased {product.ToLower()}");
        }
    else { Console.WriteLine("Sorry, not enough money"); }
    }
    else if (product == "Water")
    {
        if (change >= 0.7)
        {
            change -= 0.7;
            Console.WriteLine($"Purchased {product.ToLower()}");
        }
        else { Console.WriteLine("Sorry, not enough money"); }
    }
    else if (product == "Crisps")
    {
        if (change >= 1.5)
        {
            change -= 1.5;
            Console.WriteLine($"Purchased {product.ToLower()}");
        }
        else { Console.WriteLine("Sorry, not enough money"); }
    }
    else if (product == "Soda")
    {
        if (change >= 0.8)
        {
            change -= 0.8;
            Console.WriteLine($"Purchased {product.ToLower()}");
        }
        else { Console.WriteLine("Sorry, not enough money"); }
    }
    else if (product == "Coke")
    {
        if (change >= 1.0)
        {
            change -= 1.0;
            Console.WriteLine($"Purchased {product.ToLower()}");
        }
        else { Console.WriteLine("Sorry, not enough money"); }
    }
    else
    { Console.WriteLine("Invalid product"); }
    product = Console.ReadLine();
}
Console.WriteLine($"Change: {change:f2}");

