Console.WriteLine("-- Operadores de Atribuição --\n");

// Usando operadores de atribuição com tipos numericos

int x = 10;

Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x += 5 -> {x+=5}");
Console.WriteLine($"x -= 3 -> {x-=3}");
Console.WriteLine($"x *= 4 -> {x*=4}");
Console.WriteLine($"x /= 5 -> {x/=5}");
Console.WriteLine($"x %= 5 -> {x%=5}");

// Usando operadoes + e += com tipos de string

var y = "123";

Console.WriteLine($"Valor inicial de y = {y}");
Console.WriteLine($"y += \"456\" = {y+="456"}");

Console.ReadKey();  
