// #38 Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

double[] FillArray(int length, int topBorder, int downBorder)
{
    Random rand = new Random();
    double[] a = new double[2];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = rand.NextDouble();
    }
    return a;
}

// печатаем массив
void PrintArray(double[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}
// Находим макс и мин массива.
double MaxMin(double[] arr)
{
    double Max = int.MinValue;
    double Min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > Max) Max = arr[i];
        if (arr[i] < Min) Min = arr[i];
    }
    return (Max - Min);
}

// вывод ответа.
double[] arr = FillArray(5, 1, 6);

PrintArray(arr);

PrintResult("разница между макс и мин элементом массива " + MaxMin(arr));