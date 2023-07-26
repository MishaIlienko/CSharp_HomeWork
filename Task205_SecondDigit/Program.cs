// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
bool Validate3sign(int num)
{
    if (num >= 100 && num < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число НЕ является трехзначным!");
    return false;
}
int number = ReadInt("Введите число!");
int SecondDigit = number / 10 % 10;
if (Validate3sign(number))
{
    System.Console.WriteLine(SecondDigit);
}