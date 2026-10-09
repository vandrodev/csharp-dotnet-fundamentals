Console.WriteLine("=== 03.1 - Operadores Aritméticos ===\n");

const string ApplicationName = "Loja Virtual";
const string UnitText = "unidade(s)";

string product = "Notebook Gamer Acer Zeus";
decimal unitPrice = 5699.90m;
int quantityInStock = 250;

decimal totalValue = unitPrice * quantityInStock;

var formattedPrice = unitPrice.ToString("C");
var formattedTotalValue = totalValue.ToString("C");

Console.WriteLine(ApplicationName);
Console.WriteLine();
Console.WriteLine($"Produto: {product}");
Console.WriteLine($"Preço unitário: {formattedPrice}");
Console.WriteLine($"Quantidade em estoque: {quantityInStock} {UnitText}");
Console.WriteLine($"Valor Total em Estoque: {formattedTotalValue}");