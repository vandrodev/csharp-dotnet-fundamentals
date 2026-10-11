using _02_Construtores;

try
{
    var notebook = new Product(name: "Notebook Acer Gamer", price: 5000m, quantity: 10);
    notebook.ShowInfo();

    var mouse = new Product(name: "Mouse Gamer", price: 150m, quantity: 20);
    mouse.ShowInfo();

    var iphone = new Product(name: "iPhone 14 Pro Max", price: -12000m, quantity: 5);
    iphone.ShowInfo();
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}




Console.ReadKey();