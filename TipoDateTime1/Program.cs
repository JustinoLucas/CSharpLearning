Console.WriteLine("## Struct DateTime ##\n");

DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje : {hoje}\n");

//Extraindo informações da data Atual

//Console.WriteLine(hoje.Year);
//Console.WriteLine(hoje.Month);
//Console.WriteLine(hoje.Day);
//Console.WriteLine(hoje.Hour);
//Console.WriteLine(hoje.Minute);
//Console.WriteLine(hoje.Second);
//Console.WriteLine(hoje.Millisecond);

//Adicionando valores

//Console.WriteLine(hoje.AddDays(10));
//Console.WriteLine(hoje.AddMonths(7));
//Console.WriteLine(hoje.AddHours(2));
//Console.WriteLine(hoje.AddYears(20));

//Obtendo o dia da semana e do ano

Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//Data no formato longo e curto

Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

//oi

//Console.WriteLine(dataAtual);

//Criando uma data especifica

//DateTime dataHoje = new DateTime(2024, 09, 10);
//Console.WriteLine(dataHoje);

//Definindo horas
//DateTime dataHora = new DateTime(2024, 09, 10, 17, 51, 10);

//Console.WriteLine(dataHora);

Console.ReadKey();
