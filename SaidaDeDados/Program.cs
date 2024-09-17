Console.WriteLine("Saida de Dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";

Console.Write(nome);
Console.Write(idade);
Console.WriteLine();

// Escrevendo na mesma linha
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos\n");
Console.WriteLine("------Concatenação------");

// Usando concatenação : usando o +
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos\n");
Console.WriteLine("------Interpolação------");

// Usando a interpolação de strings :  $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos\n");
Console.WriteLine("------Place Holders------");

// Usando place holders : usa {} com numeração com inicio em zero
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();
