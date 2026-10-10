void ShowHeader(string appName)
{
    Console.WriteLine("===================================");
    Console.WriteLine($"         {appName}                 ");
    Console.WriteLine("===================================\n");
}

decimal CalculateTotal(decimal price, int quantity)
{
    return price * quantity;
}

bool HasStock(int quantity)
{
    return quantity > 0;
}

void ShowProduct(string name, decimal price, int quantity)
{
    Console.WriteLine($"Produto: {name}");
    Console.WriteLine($"Preço: {price:C}");
    Console.WriteLine($"Quantidade: {quantity}");
    Console.WriteLine($"Tem estoque: {(HasStock(quantity) ? "Sim" : "Não")}");
    Console.WriteLine($"Valor Total: {CalculateTotal(price, quantity):C}");
    Console.WriteLine("\n");
}

ShowHeader(appName: "Loja Virtual");
ShowProduct(name: "Notebook Gamer Acer Zeus", price: 5699.90m, quantity: 250);
ShowProduct(name: "Mouse", price: 50.00m, quantity: 5);
ShowProduct(name: "Teclado Mecânico", price: 250.00m, quantity: 0);

Console.ReadKey();