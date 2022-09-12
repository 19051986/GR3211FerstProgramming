//===========================================================
// #0 Напишите программу, которая на вход принимает число и 
// выдает его квадрат (число умноженное на само себя).
//===========================================================

// чтение данных из консоли.
string? inputLine = Console.ReadLine();
// получение данных.
if(inputLine != null)
{
 int inputNumber = int.Parse(inputLine);
 int outNumber = inputNumber * inputNumber;
 // вывод результата.
 Console.WriteLine(outNumber);   
}