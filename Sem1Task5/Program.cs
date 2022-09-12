//==================================================================
// # 7 Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
//==================================================================

// чтение данных из консоли.
string? inputLineN = Console.ReadLine();
// получение данных.
if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    if (inputNumberN > 0)
    {
        int startNumber = (-1) * inputNumberN;
        while (startNumber < inputNumberN)
        {
            // вывод результата.
            Console.Write(startNumber + ", ");
            startNumber = startNumber + 1;
        }
        // вывод результата.
        Console.Write(inputNumberN);
    }
}
