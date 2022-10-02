//#50 Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, печатает двумерный массив
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод генерации и заполнения массива
int[,] Fill2DArray(int rows, int cols, int numMin, int numMax)
{
    // Создаём массив
    int[,] array2D = new int[rows, cols];

    if (numMin < numMax)
    {
        // Заполняем массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = new Random().Next(numMin, numMax + 1);
            }
        }
    }

    return array2D;
}

int FindElem(int x, int y, int[,] array)
{
    if (x < array.GetLength(0) && y < array.GetLength(1))
    {
        return array[x, y];
    }
    else
    {
        return -1;
    }
}
//Вывод результата.
int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 0, 99);
int x = ReadData("Введите номер строки эллемента: ");
int y = ReadData("Введите номер столбца : ");
int res = FindElem(x, y, arr2D);
Print2DArray(arr2D);
void PrintAnswer(int answer)
{
    if (answer == -1)
        Console.WriteLine("Заданной позиции не существуе в данном массиве ");

    else
        Console.WriteLine("искомый элемент  " + answer);
}
PrintAnswer(res);