//======================================================================
// # 5 Напишите программу, которая принимает на вход трехзначное число и 
//  на выходе показывет последнюю цифру этого числа.
//======================================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 99 && inputNumber<1000)
    {
        int lastDigit = inputNumber%10;
        Console.Write(lastDigit);
        
    }
}
