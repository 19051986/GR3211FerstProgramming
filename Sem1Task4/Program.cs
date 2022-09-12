//==============================================================
// #4 Напишите программу, которая принимает на вход три числа и
// выдает максимальное из этих чисел.
//==============================================================

// чтение данных из консоли.
string? inputLineA = Console.ReadLine() ?? "";
string? inputLineB = Console.ReadLine() ?? "";
string? inputLineC = Console.ReadLine() ?? "";
// получение данных.
int inputnumberA = int.Parse(inputLineA);
int inputnumberB = int.Parse(inputLineB);
int inputnumberC = int.Parse(inputLineC);
int inputnumbermax ;

inputnumbermax = inputnumberB > inputnumberA ? inputnumberB : inputnumberA;
inputnumbermax = inputnumbermax > inputnumberC ? inputnumbermax : inputnumberC;
// вывод результата.
Console.WriteLine(inputnumbermax);

