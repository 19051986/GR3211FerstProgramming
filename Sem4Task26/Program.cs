// чтение данных из консоли
int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    // считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return numberP;
}

// метод вывода результата.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Вариант с логарифмом.
int CalculateDigits(int num)
{
    return (int)(Math.Log10(num) + 1);
}
// Вариант с длиной строки.
int CalculateDigitsString(int num)
{
    string numString = num.ToString();
    return numString.Length;
}

int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += 1;
        num = num / 10;
    }
    return num;
}

int number = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
int numberOFDigits = CalculateDigits(number);
Console.WriteLine(DateTime.Now - d1);
PrintResult("Количество цифр в числе: " + numberOFDigits);
DateTime d2 = DateTime.Now;
numberOFDigits = CalculateDigitsString(number);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Количество цифр в числе: " + numberOFDigits);
DateTime d3 = DateTime.Now;
numberOFDigits = CalculateDigits(number);
Console.WriteLine(DateTime.Now - d3);
PrintResult("Количество цифр в числе: " + numberOFDigits);