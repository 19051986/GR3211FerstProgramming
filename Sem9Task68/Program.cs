// #68 Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем значение
    return int.Parse(Console.ReadLine() ?? "");
}

// Функция Аккермана.
int AckermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermanRec(m - 1, 1);
    return AckermanRec(m - 1, (int)AckermanRec(m, n - 1));
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");
PrintData(AckermanRec(m,n).ToString());