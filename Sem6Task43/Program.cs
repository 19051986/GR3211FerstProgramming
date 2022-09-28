// #43 напишите программу, которая найдет точку пересечения двух
// прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2.

// Получение данных от пользователя и преобразование в число
double pointX;
double pointY;

Console.Write("Введите по очереди b1, k1, b2, k2 одной строкой через пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr[1];
int b = arr[3];
int c = arr[0];
int d = arr[2];

if (a == b)
{
    Console.WriteLine("Прямые паралельны");
}
else
{// Нахождение точки перечечения и вывод результата.
    pointX = (double)(d - c) / (a - b);
    pointY = (double)a * (d - c) / (a - b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых: ");
    Console.WriteLine($"X: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}

