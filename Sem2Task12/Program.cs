﻿//=================================================================================
// #12 Напишите программу, которая будет принимать на вход два числа и
// выводить, является ли второе число каратным первому. Если вотрое число не кратно
// первому, то программа выводит остаток от деления
//=================================================================================

void Variant1()
{
    // чтение данных из консоли.
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    // чтение данных из консоли.
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();
// получение данных.
    int inputnumberA = int.Parse(inputLineA);
    int inputnumberB = int.Parse(inputLineB);
// вывод результата.
Console.WriteLine((inputnumberB % inputnumberA == 0)? ("Второе число кратно первому") : ("остаток от деления: " + inputnumberB % inputnumberA));
} 
Variant1();