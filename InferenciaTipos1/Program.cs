Console.WriteLine("-- Inferência de Tipos (var) --\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

// Var limitações

var salario = null;
var titulo;
var salario, imposto, total;

// Não posso mudar o tipo apos inicializar

var num = 10;
num = num + 20;
num = "teste";



Console.ReadKey();

var teste = new Teste();

teste.MeuMetodo();
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu metodo");
    }
}
