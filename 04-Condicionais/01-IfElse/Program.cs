Console.WriteLine("=== 04.1 - if / else ===\n");

int quantityInStock = 250;
bool isActiveForSale = true;

bool hasStock = quantityInStock > 0;
bool isLowStock = quantityInStock <= 20;
bool canSell = hasStock && isActiveForSale;

if (canSell)
{
    Console.WriteLine("Produto disponível para venda");
}
else if (isLowStock)
{
    Console.WriteLine("Atenção: estoque baixo");
}
else
{
    Console.WriteLine("Produto indisponível");
}