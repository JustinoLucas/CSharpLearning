using System.Drawing;

Console.WriteLine("== Nullable Types ==\n");

//Nullable<int> i = null;
//Nullable<double> d = null;
//Nullable<bool> b = null;

//int? i = null;
//double? d = null;
//bool? b = null;

//int? a = null;
//int b = a ?? 0;

//Console.WriteLine(b);


//Console.WriteLine(i);
//Console.WriteLine(d);
//Console.WriteLine(b);


//int? x = 4;
//int? y = 3;
//int? z = x * y;

//Console.WriteLine(z); 


int? b = 100;
if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}


Console.ReadLine();