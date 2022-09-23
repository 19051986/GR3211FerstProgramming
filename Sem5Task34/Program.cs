// #34 Напишите программу, которая покажет количество чётных чисел в массиве

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
int EvenCount(int[] arr)
{
    int X = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (EventTest(arr[i]))
        {
            X++;
        }
    }
    return X;
}
// проверка на чётные числа.
bool EventTest(int a)
{
    return (a % 2 == 0);
}
// вывод ответа.
int[] arr = FillArray(123, 100, 999);

PrintArray(arr);

PrintResult("В массиве чётных чисел " + EvenCount(arr));

