//=========================================================================
// # 1 Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
//=========================================================================

// чтение данных из консоли.
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
// получение данных.
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    bool outResult = (inputNumberA * inputNumberA == inputNumberB);
// вывод результата.
    Console.WriteLine(outResult);
}