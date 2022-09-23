// # 36 Задайте одномерный массив, заполненный случайными числами. Найдите
// сумму элементов, стоящих на нечётных позициях.
// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] FillArray(int length, int topBorder, int downBorder)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}

// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// считаем четные числа в массиве
int EvenSumPos(int[] arr)
{
    int X = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        X += arr[i];
    }
    return X;
}

// вывод ответа.
int[] arr = FillArray(5, 1, 25);

PrintArray(arr);

PrintResult("сумма элементов на нечётных позициях " + EvenSumPos(arr));
