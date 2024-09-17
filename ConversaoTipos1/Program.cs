Console.WriteLine("-- Conversão de Tipos --\n");

// Conversão Implicita

//int varInt = 100;  // Int usa 4 bytes
//double varDouble = varInt; // Double usa 8 bytes

//Console.WriteLine(varDouble);

//int numeroInt = 2567890;
//long numeroLong = numeroInt;
//float numeroFloat = numeroInt;
//double numeroDouble = numeroInt;
//decimal numeroDecimal = numeroInt;

//Console.WriteLine(numeroInt);
//Console.WriteLine(numeroLong);
//Console.WriteLine(numeroFloat);
//Console.WriteLine(numeroDouble);
//Console.WriteLine(numeroDecimal);

// Conversão Explitica

//double varDouble2 = 12.456;
//int varInt2 = (int)varDouble2;//Perda de precisão

//Console.WriteLine(varInt2);

//int num1 = 10;
//int num2 = 4;

//float resultado = (float)num1 / num2; // 10/4 = 2.5
//Console.WriteLine(resultado);

// Conversão ToString()

//int valorInt = 123;
//double valorDouble = 12.45;
//decimal valorDecimal = 12.45678m;

//string s1 = valorInt.ToString();
//string s2 = valorDouble.ToString();
//string s3 = valorDecimal.ToString();

//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);

int valorInt = 10;
double valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble));

Console.ReadLine();
