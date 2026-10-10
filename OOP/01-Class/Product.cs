namespace _01_Class;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal CalculateTotal()
    {
        return Price * Quantity;
    }

    public bool HasStock()
    {
        return Quantity > 0;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Produto: {Name}");
        Console.WriteLine($"Preço: {Price:C}");
        Console.WriteLine($"Quantidade: {Quantity}");
        Console.WriteLine($"Tem estoque: {(HasStock() ? "Sim" : "Não")}");
        Console.WriteLine($"Valor Total: {CalculateTotal():C}");
        Console.WriteLine();
    }
}
