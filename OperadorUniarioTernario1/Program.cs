﻿Console.WriteLine("-- Operador Uniário e Ternário --\n");

//int positivo = 1;
//int resultado;
//resultado = +positivo;

//Console.WriteLine(resultado);

//Console.WriteLine("Informe um numero :\n");
//var n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"O negativo de {n} é igual a {-n}");


//Console.WriteLine("Informe uma temperatura: \n");
//var temp = Convert.ToDouble(Console.ReadLine());

//var resultado = temp > 27 ? "Quente" : "normal";

//Console.WriteLine($"O tempo está {resultado}");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

string resultado = x > y ? "x é maior que y" :
                   x < y ? "x é menor que y" :
                   x == y ? "x é igual a y" : "Sem resultado";
Console.WriteLine(resultado);

Console.ReadKey();
