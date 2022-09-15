//=========================================================================
// # 19 Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
//=========================================================================

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int polin = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return polin;
}

// проверяет число на полиндром
bool TestPalin(int polin)
{
    if ((polin / 10000 == polin % 10) && (polin / 1000) % 10 == (polin / 10) % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintData(int palin)
{
    if (TestPalin(palin))
    {
        Console.WriteLine("palindrom");
    }
    else
    {
        Console.WriteLine(" no palindrom");
    }
    if ((palin < 9999) && (palin > 100000))
    {
        Console.WriteLine(" try again");
    }
}
// собираем данные
int polin = ReadData("Введите число");

PrintData(polin);
