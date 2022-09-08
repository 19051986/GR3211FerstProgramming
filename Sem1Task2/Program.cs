//==============================================================
// #2 Напишите программу, которая на вход принимает два числа и
// выдает, какое большее, а какое меньшее.
//==============================================================

string? inputLineN = Console.ReadLine()??"";
string? inputLineM = Console.ReadLine()??"";

int inputnumberN = int.Parse(inputLineN);
int inputnumberM = int.Parse(inputLineM);

if (inputnumberN > inputnumberM)
{
    Console.WriteLine("max N");
}
else
{
    Console.WriteLine("max M");
}

