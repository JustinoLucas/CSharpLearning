Console.WriteLine("-- Operadores de Incremento e Decremento --\n");

//int x = 10;
//x++;
int x = 0;

Console.WriteLine($"x = {x}");

// pós-incremento -> primeiro resolve depois incrementa
int resultado1 = x++ + 10;
Console.WriteLine($"pós-incremento -> {resultado1}");
Console.WriteLine($"valor de x -> {x}\n");

// pré-incremento -> primeiro incrementa depois resolve a expressão
int y = 0;
Console.WriteLine($"y = {y}");
int resultado2 = ++y + 10;
Console.WriteLine($"pré-incremento -> {resultado2}");
Console.WriteLine($"valor de y -> {y}\n");

// pós-decremento -> primeiro resolve depois decrementa
int g = 0;
Console.WriteLine($"g = {g}");
int resultado3 = g-- + 10;
Console.WriteLine($"pós-decremento -> {resultado3}");
Console.WriteLine($"valor de g -> {g}\n");

// pré-incremento -> primeiro decrementa depois resolve a expressão
int h = 0;
Console.WriteLine($"h = {h}");
int resultado4 = --h + 10;
Console.WriteLine($"pré-decremento -> {resultado4}");
Console.WriteLine($"valor de h -> {h}\n");


Console.ReadKey();
