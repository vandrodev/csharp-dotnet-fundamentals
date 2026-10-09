Console.WriteLine("=== 01 - Variáveis e Tipos ===\n");

string name = "Ana Silva";
int age = 28;
double heightInMeters = 1.65;
bool isEmployed = true;
decimal salary = 4500.00m;

var formattedHeight = heightInMeters.ToString("0.00");
var formattedIsEmployed = isEmployed ? "Sim" : "Não";
var formattedSalary = salary.ToString("C");

Console.WriteLine($"Nome: {name}");
Console.WriteLine($"Idade: {age} anos");
Console.WriteLine($"Altura: {formattedHeight} m");
Console.WriteLine($"Empregado: {formattedIsEmployed}");
Console.WriteLine($"Salário: {formattedSalary}");