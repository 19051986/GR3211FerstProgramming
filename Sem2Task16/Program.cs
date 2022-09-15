// чтение данных из консоли
int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}
// тест на квадрат
bool SqrTest(int ferstNum, int secondNum)
{
    if (ferstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}
// вывод данных
void PrintData(int ferstNum, int secondNum)

{
    if (SqrTest(ferstNum, secondNum))
    {
        Console.WriteLine("число " + ferstNum + "квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("число " + ferstNum + "не квадрат числа " + secondNum);
    }

}

int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");

PrintData(num1, num2);
PrintData(num2, num1);

