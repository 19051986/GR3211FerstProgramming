//==============================================================
// #4 Напишите программу, которая принимает на вход три числа и
// выдает максимальное из этих чисел.
//==============================================================

string? inputLineA = Console.ReadLine() ?? "";
string? inputLineB = Console.ReadLine() ?? "";
string? inputLineC = Console.ReadLine() ?? "";

int inputnumberA = int.Parse(inputLineA);
int inputnumberB = int.Parse(inputLineB);
int inputnumberC = int.Parse(inputLineC);
int inputnumbermax = 0;

inputnumbermax = inputnumberB > inputnumberA ? inputnumberB : inputnumberA;
inputnumbermax = inputnumbermax > inputnumberC ? inputnumbermax : inputnumberC;

Console.WriteLine(inputnumbermax);

