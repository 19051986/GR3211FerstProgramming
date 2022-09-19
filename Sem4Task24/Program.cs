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

int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 0; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число A:");

DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A равна(простой метод):" + res1);
PrintResult("Сумма чисел от 1 до A равна(метод Гауса):" + res2);