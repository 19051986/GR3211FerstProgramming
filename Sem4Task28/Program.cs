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

//Вариант с логарифмомю
long CalculateFactorial(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

long CalcData(int num)
{
    if (num == 1)
        return 1;
    return num * CalcData(num - 1);
}

int number = ReadData("Введите число: ");
long factorial = CalculateFactorial(number);
PrintResult("Факториал равен: "+ factorial);
long factorialAnatoliy = CalcData(16);
PrintResult("Факториал равен: "+ factorialAnatoliy);
