// #58 Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

// Генерация случайного 2D массива.
int[,] Gen2DArr(int rows, int columns, int arrMin, int arrMax)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr;
}

// Возращает строку масива.
int[] GetRow(int[,] arr, int iRow)
{
    int[] row = new int[arr.GetLength(1)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = arr[iRow, j];
    }
    return row;
}

// Возращает Столбец масива.
int[] GetColumn(int[,] arr, int iRow)
{
    int[] row = new int[arr.GetLength(0)];
    for (int j = 0; j < row.Length; j++)
    {
        row[j] = arr[j, iRow];
    }
    return row;
}

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Печать 2D массива.
void Print2DArr(int[,] arr)
{
    if (arr != null)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            PrintData(string.Join(", ", GetRow(arr, i)), "[", "]");
        }
    }
    else PrintData("Произведение матриц невозможно.");
}

// Сумма элементов 1D массива.
int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

// Поэлементное произведение массивов.
int[] Multiplic(int[] arrX, int[] arrY)
{
    int[] result = new int[arrX.Length];
    for (int i = 0; i < arrX.Length; i++)
    {
        result[i] = arrX[i] * arrY[i];
    }
    return result;
}

// Произведение Матриц.
int[,] MatrixMultiplic(int[,] arrX, int[,] arrY)
{
    int[,] result = new int[arrX.GetLength(0), arrY.GetLength(1)];
    if (arrX.GetLength(1) == arrY.GetLength(0))
    {

        for (int i = 0; i < arrX.GetLength(0); i++)
        {
            for (int j = 0; j < arrY.GetLength(1); j++)
            {
                result[i, j] = Sum(Multiplic(GetRow(arrX, i), GetColumn(arrY, j)));
            }
        }
        return result;
    }
    return null;
}



int[,] arrX = Gen2DArr(3, 2, 1, 10);
int[,] arrY = Gen2DArr(2, 3, 1, 10);
PrintData("Матрица X: ");
Print2DArr(arrX);
PrintData("Матрица Y: ");
Print2DArr(arrY);
PrintData("Произведение матриц X на Y: ");
Print2DArr(MatrixMultiplic(arrX, arrY));
