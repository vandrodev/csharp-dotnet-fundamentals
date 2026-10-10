namespace _02_Construtores;

public class Product
{
    private decimal _price;
    private int _quantity;
    public string Name { get; set; }
    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0) throw new ArgumentException("Preço não pode ser negativo");
            _price = value;
        }
    }
    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0) throw new ArgumentException("Quantidade não pode ser negativa");

            _quantity = value;
        }
    }

    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

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
