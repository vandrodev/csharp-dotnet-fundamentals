Console.WriteLine("=== 03.2 - Operadores de Comparação ===\n");

decimal unitPrice = 5699.90m;
int quantityInStock = 250;

bool hasStock = quantityInStock > 0;
bool isLowStock = quantityInStock <= 20;
bool isExpensive = unitPrice >= 5000m;

var formattedHasStock = hasStock ? "Sim" : "Não";
var formattedIsLowStock = isLowStock ? "Sim" : "Não";
var formattedIsExpensive = isExpensive ? "Sim" : "Não";

Console.WriteLine($"Tem estoque: {formattedHasStock}");
Console.WriteLine($"Estoque baixo: {formattedIsLowStock}");
Console.WriteLine($"Produto caro: {formattedIsExpensive}");