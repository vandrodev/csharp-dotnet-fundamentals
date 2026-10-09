string orderStatus = "Shipped";

switch (orderStatus)
{
    case "Pending":
        Console.WriteLine("Pedido pendente");
        break;
    case "Processing":
        Console.WriteLine("Pedido em processamento");
        break;
    case "Shipped":
        Console.WriteLine("Pedido enviado");
        break;
    case "Delivered":
        Console.WriteLine("Pedido entregue");
        break;
    case "Cancelled":
        Console.WriteLine("Pedido cancelado");
        break;
    default:
        Console.WriteLine("Status desconhecido");
        break;
}