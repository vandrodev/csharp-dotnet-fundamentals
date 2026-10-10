using _02_Construtores;

var notebook = new Product(name: "Notebook Acer Gamer", price: 5000m, quantity: 10);
var mouse = new Product(name: "Mouse Gamer", price: 150m, quantity: 0);

var iphone = new Product(name: "iPhone 14 Pro Max", price: -12000m, quantity: 5);

notebook.ShowInfo();
mouse.ShowInfo();
iphone.ShowInfo();

Console.ReadKey();