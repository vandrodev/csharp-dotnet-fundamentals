Console.WriteLine("Loop While\n");

int counter = 1;
while (counter <= 10)
{
    Console.WriteLine($"Número: {counter}");
    counter++;
}

Console.WriteLine("\n");

int number = 2;
while (number <= 20)
{
    Console.WriteLine($"Número par: {number}");
    number += 2;
}

Console.WriteLine("\n");

int inStock = 5;
while (inStock > 0)
{
    Console.WriteLine($"Estoque atual: {inStock}");
    inStock--;

    if (inStock == 0)
    {
        Console.WriteLine("Estoque esgotado!");
    }
}

Console.ReadKey();