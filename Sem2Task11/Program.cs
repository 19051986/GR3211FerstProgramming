//========================================================================
// #11 Напишите программу, которая выводит случайное трёхзначное число  и 
// удаляет вторую цифру этого числа.
//========================================================================

// чтение данных из консоли.
System.Random numberGenerator = new System.Random();
// получение данных.
int number = numberGenerator.Next(100,1000);

Console. WriteLine(number);

int firstDigit = number / 100;
int thirdDigit = number % 10;
// вывод результата.
Console.WriteLine(firstDigit*10+thirdDigit);