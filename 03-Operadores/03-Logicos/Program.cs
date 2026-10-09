Console.WriteLine("=== 03.3 - Operadores Lógicos ===\n");

decimal unitPrice = 5699.90m;
int quantityInStock = 250;
bool isActiveForSale = true;

bool hasStock = quantityInStock > 0;
bool isLowStock = quantityInStock <= 20;
bool isExpensive = unitPrice >= 5000m;

bool canSell = hasStock && isActiveForSale;
bool needsAttention = isLowStock || !isActiveForSale;
bool isPremiumAvailable = isExpensive && canSell;

var formattedCanSell = canSell ? "Sim" : "Não";
var formattedNeedsAttention = needsAttention ? "Sim" : "Não";
var formattedIsPremiumAvailable = isPremiumAvailable ? "Sim" : "Não";

Console.WriteLine($"Pode vender: {formattedCanSell}");
Console.WriteLine($"Precisa de atenção: {formattedNeedsAttention}");
Console.WriteLine($"Premium disponível: {formattedIsPremiumAvailable}");