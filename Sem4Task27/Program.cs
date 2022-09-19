// #27 Напишите программу, которая принимает на вход число и 
// выдает сумму цифр в числе.

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

// метод вывода результата.
void PrintResult(string line)
{
    Console.WriteLine(line);
}
// Обьявление переменой.
int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num%10;
        num = num / 10;
    }
    return sum;
}
// Вывод результата.
int number = ReadData("Введите число: ");
int res = SumDigit(number);
PrintResult("Сумма цифр в числе: " + res);