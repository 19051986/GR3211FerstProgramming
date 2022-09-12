//==============================================================
// #2 Напишите программу, которая на вход принимает два числа и
// выдает, какое большее, а какое меньшее.
//==============================================================

// чтение данных из консоли.
string? inputLineN = Console.ReadLine()??"";
string? inputLineM = Console.ReadLine()??"";
// получение данных.
int inputnumberN = int.Parse(inputLineN);
int inputnumberM = int.Parse(inputLineM);

if (inputnumberN > inputnumberM)
{
    // вывод результата.
    Console.WriteLine("max N");
}
else
{
    // вывод результата.
    Console.WriteLine("max M");
}

