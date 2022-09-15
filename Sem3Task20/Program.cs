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
// расстояние между двумя точками
double CalcData(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

// Соберем данные.
int x1 = ReadData("Введите x1 ");
int y1 = ReadData("Введите y1 ");
int x2 = ReadData("Введите x2 ");
int y2 = ReadData("Введите y2 ");
// Выведем результат.
PrintResult(Math.Round(CalcData(x1, y1, x2, y2), 3).ToString());



