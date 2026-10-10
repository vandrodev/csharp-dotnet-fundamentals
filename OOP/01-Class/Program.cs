using _01_Class;

var notebook = new Product
{
    Name = "Notebook",
    Price = 56999.90m,
    Quantity = 250
};

var mouse = new Product
{
    Name = "Mouse",
    Price = 259.99m,
    Quantity = 500
};

notebook.ShowInfo();
mouse.ShowInfo();

Console.ReadKey();