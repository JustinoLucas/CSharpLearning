using System;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Exercicios Fase 2");
// 1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings
//string nome = "Paulo";
//int idade = 17;
//float nota = 7.5f;

//Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
//Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

// 2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

//Console.WriteLine($"Aluno {nome} \ntem {idade} anos \ne nota {nota}");

// 3- Para qual tipo de dados você pode converter um float implicitamente ?
//( V ) int
//( F ) double
//( F ) long
//( F ) decimal

// 4 - Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
//( F ) int para long
//( F ) double para long
//( V ) double para float
//( V ) decimal para float
//( V ) long para int
//( F ) double para decimal

//5 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
//Console.WriteLine("Digite 3 letra: ");
//char l1 = Convert.ToChar(Console.ReadLine());
//char l2 = Convert.ToChar(Console.ReadLine());
//char l3 = Convert.ToChar(Console.ReadLine());

//Console.WriteLine("Ordem Reversa " + l3 + l2 + l1);
//Console.WriteLine($"Ordem Reversa {l3}{l2}{l1}");

// 6 - Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
//( F ) long resultado = 1.32;
//( V ) var nome = “Maria”;
//( V ) string resultado = 100.ToString();
//( V ) A sequência de escape \n inclui uma nova linha
//( F ) float f = 5.45;
//( V ) decimal valor = (decimal)10.99f;
//( F ) var status = null;
//( V ) object o = 12.45m;
//( V ) string titulo = true.ToString();
//( F ) A sequencia \t inclui uma tabulação vertical

// 7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
//exibindo o resultado:
//Console.WriteLine("digite um valor para x e outro para y");
//var n1 = Convert.ToInt32(Console.ReadLine());
//var n2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Soma x + y = {n1+n2}");
//Console.WriteLine($"Subtração x + y = {n1-n2}");
//Console.WriteLine($"Multiplicação x + y = {n1*n2}");
//Console.WriteLine($"Exponenciação x = {Math.Exp(n1)}");
//Console.WriteLine($"Divisão x / y = {n1/n2}");
//Console.WriteLine($"Resto x % y = {n1%n2}");


// 8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de a b e c .
//Valores : a = 1 , b = 12 e c = -13

//var a = 1;
//var b = 12;
//var c = -13;

//var delta = Math.Pow(b, 2) - 4 * a * c;

//var baskhara1 = (-b + Math.Sqrt(delta)) / (2 * a);
//var baskhara2 = (-b - Math.Sqrt(delta)) / (2 * a);
//Console.WriteLine(baskhara1);
//Console.WriteLine(baskhara2);

// 9 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
//Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
//então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
//inválido’: (use o operador condicional ternário)

//string admin;
//int senha;
//Console.WriteLine("Digite um Login");
//admin = Console.ReadLine();
//Console.WriteLine("Digite uma Senha");
//senha = Convert.ToInt32(Console.ReadLine());

//string resultado = (admin == "admin" || admin == "maria") && senha == 123 ? "Login feito com sucesso" : "Login Invalido";
//Console.WriteLine(resultado);

// 10 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis considerando
//a nomenclatura usada:
//( V ) string? nome; é um exemplo de nullable reference type;
//( F ) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
//( F ) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
//( V ) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
//( F ) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
//( F ) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
//( V ) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
//( F ) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
//( V ) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
//( V ) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
//( V ) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"

// 11 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

//Console.WriteLine("Digite 2 numeros :");
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());

//var resultado1 = x % 2 == 0 ? " X é Par" : "X é Impar";
//var resultado2 = y % 2 == 0 ? " Y é Par" : "Y é Impar";

//Console.WriteLine($"{resultado1} e {resultado2}");

// 12 - Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no
//console o resultado das seguintes operações : (x ^ 2->x ao quadrado) (pi = 3.1415)
//-6 + x * 5
//(13-2) * x
//(x + -2) * (20 / x)
//(12 + x) / (x - 4)
//3 x^2 + x + 10
//pi * x^2

//int x;
//const double PI = 3.1415;
//Console.WriteLine("Digite um numero :");
//x = Convert.ToInt32(Console.ReadLine());
//var quad = Math.Exp(x);

//Console.WriteLine($"-6 + x * 5 = {-6 + x * 5}");
//Console.WriteLine($"(13-2) * x = {(13 - 2) * x}");
//Console.WriteLine($"(x + -2) * (20 / x) = {(x + -2) * (20 / x)}");
//Console.WriteLine($"(12 + x) / (x - 4) = {(12 + x) / (x - 4)}");
//Console.WriteLine($"3 x^2 + x + 10 = {3 + quad + x + 10}");
//Console.WriteLine($"pi * x^2 = {PI * quad}");

//13 - Considere o seguinte trecho de código:

//int y = 5;
//y =  y++ + y + ++y;
//Console.WriteLine(y);


//14 - Escreva um programa que solicite a temperatura em graus Celsius e converta para
//Kelvin e Farhenheit usando as fórmulas a seguir:
//-Converter para Kelvin => K = C + 273;
//-Converter para Farhenheit => F = (C * 9) / 5 + 32;

//Console.WriteLine("Digite uma temperatura em Celsius : ");
//double temp = Convert.ToDouble(Console.ReadLine());

//var K = temp + 273.15;
//var F = (temp * 9) / 5 + 32;
//Console.WriteLine($"Temperatura em Kelvin : {K}");
//Console.WriteLine($"Temperatura em Farhenheit : {F}");

//15 - Escolha a opção que representa a exibição do resultado para o código usando os
//operadores de decremento e incremento (pré e pós) : 

//var numero = 5;
//Console.WriteLine(numero++);
//numero = 1;
//Console.WriteLine(++numero);
//numero = 2;
//Console.WriteLine(numero--);
//numero = 3;
//Console.WriteLine(--numero);
//Console.ReadKey();

//5 2 2 2
