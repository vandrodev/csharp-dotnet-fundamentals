Console.WriteLine("=== 02 - Constantes ===\n");

const string ApplicationName = "Loja Virtual";
const string DefaultUnitWeight = "kg";
const string UnitText = "unidade(s)";

string product = "Notebook Gamer Acer Zeus";
string productCode = "A1B-0012026";
decimal unitPrice = 5699.90m;
int quantityInStock = 250;
bool isActiveForSale = true;
double productWeight = 2.45;

var formattedPrice = unitPrice.ToString("C");
var formattedIsActiveForSale = isActiveForSale ? "Sim" : "Não";
var formattedWeight = productWeight.ToString("F2");

Console.WriteLine(ApplicationName);
Console.WriteLine();
Console.WriteLine($"Produto: {product}");
Console.WriteLine($"Código: {productCode}");
Console.WriteLine($"Preço: {formattedPrice}");
Console.WriteLine($"Estoque: {quantityInStock} {UnitText}");
Console.WriteLine($"Ativo: {formattedIsActiveForSale}");
Console.WriteLine($"Peso: {formattedWeight} {DefaultUnitWeight}");