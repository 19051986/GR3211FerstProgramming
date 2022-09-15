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

string QuterBorderAsk(int numQuter)
{

    if (numQuter == 1)
        return "x>0 y>0";
    if (numQuter == 2)
        return "x<0 y>0";
    if (numQuter == 3)
        return "x<0 y<0";
    if (numQuter == 4)
        return "x>0 y<0";

    return "";
}
// результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите номер четверти: ");

string res = QuterBorderAsk(num);

PrintResult(res);


