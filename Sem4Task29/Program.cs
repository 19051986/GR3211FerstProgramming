//#29 Напишите программу, которая задает массив из 8 элементов и 
// выводит их на экран.

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
// Длина массива.
int[] GenArr(int num, int start, int stop)
{// генерируем числа.
    Random ren = new Random();
    // Создаем массив.
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ren.Next(start, stop);
    }
    return arr;
}
// печатаем(выводим массив).
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}
int arrLen = 8;
int starting = ReadData("Введите начальное значение массива ");
int stoping = ReadData("Введите конечное значение массива ");
int[] array = GenArr(arrLen, starting, stoping);
PrintArr(array);

