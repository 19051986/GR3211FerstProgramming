//===========================================================================
// #9 Напишите программу, которая выводмт случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
//===========================================================================

// чтение данных из консоли.
System.Random numberGenerator = new System.Random();
// получение данных.
int number = numberGenerator.Next(10,100);

Console.WriteLine(number);

int ferstDigit = number/10;
int secondDigit = number%10;

if(ferstDigit>secondDigit)
{
  // вывод результата.
    Console.WriteLine(ferstDigit);
}
else
{
  // вывод результата.
  Console.WriteLine(secondDigit);  
}