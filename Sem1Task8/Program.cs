//================================================================
// # 8 Напишите программу, которая принимает на вход число (N), а 
//  на выходе показывет все четные числа от 1 до N.
//================================================================

// чтение данных из консоли.
string? inputLineN = Console.ReadLine();
// получение данных.
int NumberN = int.Parse(inputLineN);
if (NumberN > 1)
{
    int startNumber = 1;
    while (startNumber < NumberN)
    {
        // вывод результата.
        Console.Write(startNumber + ", ");
        startNumber = startNumber + 1;
    }
    // вывод результата.
    Console.Write(NumberN);
}
