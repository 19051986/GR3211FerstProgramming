//======================================================================
// #23 Напишите программу, которая принимает на вход число (N) и выдает
// таблицу кубов чисел от 1 до N.1.
//======================================================================

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

string LineNumbers(int N)

{
    int i = 1;
    string outLine = string.Empty;
    while (i < N)
    {
        outLine = outLine + i + "\t ";
        ++i;
    }
    outLine = outLine + N;
    return outLine;
}

string LineSqer(int N)

{
    int i = 1;
    string outLine = string.Empty;
    while (i < N)
    {
        outLine = outLine + i * i * i + "\t ";
        ++i;
    }
    outLine = outLine + N*N*N;
    return outLine;
}
// вывод данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");
string LineTop = LineNumbers(num);
string LineDown = LineSqer(num);

PrintResult(LineTop);
PrintResult(LineDown);
