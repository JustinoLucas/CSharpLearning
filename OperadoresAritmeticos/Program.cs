Console.WriteLine("-- Operadores Aritmeticos --\n");

Console.WriteLine("Informe o valor de X");
int x  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de Y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nRaiz Quadrada de X = {Math.Sqrt(x)}");
Console.WriteLine($"\nPotencia de X elevado a Y= {Math.Pow(x,y)}");
Console.WriteLine($"\nValor Minimo de X e Y= {Math.Min(x,y)}");
Console.WriteLine($"\nValor Maximo de X e Y= {Math.Max(x,y)}");
Console.WriteLine($"\nCoseno de X = {Math.Cos(x)}");
Console.WriteLine($"\nSeno de X = {Math.Sin(x)}");
Console.WriteLine($"\nExponencial de X = {Math.Exp(x)}");


Console.ReadKey();

//Console.WriteLine($"Soma de X + Y = {x + y}");
//Console.WriteLine($"Subtração de X - Y = {x - y}");
//Console.WriteLine($"Multiplicação de X * Y = {x * y}");
//Console.WriteLine($"Divisão de X / Y = {(double)x / y}");
//Console.WriteLine($"Resto de X % Y = {x % y}");
