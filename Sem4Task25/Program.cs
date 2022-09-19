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

void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Решение через степень.

double Step(int X, int Y)
{
    double StepMath = Math.Pow(X, Y);
    return StepMath;
}
int X = ReadData("Введите число X: ");
int Y = ReadData("Введите степень Y: ");
double Powres = Step(X, Y);
PrintResult("Число" + X + "в степени" + Y + "равно:" + Powres);
