Console.WriteLine("\n -- Entrada de Dados --");

Console.WriteLine("\nInforme o seu nome");

string nome = Console.ReadLine();

Console.WriteLine("O seu nome é " + nome);

Console.WriteLine("\nInforme o sua idade");

int idade = Convert.ToInt32(Console.ReadLine());
int idade2 = int.Parse(Console.ReadLine());

Console.WriteLine($"\nSua idade é {idade}");
Console.WriteLine($"\nSua idade é {idade2}");

Console.ReadKey();
