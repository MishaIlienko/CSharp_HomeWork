// Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, 
//что третьей цифры нет. 
//Не использовать строки для расчета.

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
bool Validate3sign (int num)
{
    if (num >=100 && num < 1000)
    {
        return true;
    }
    return false;
}
int number = ReadInt("Веведите число!");
int rest10 = 0;
int thirdDigit = 0;
if (number > 100)
{
    while (number > 0)
    {
        rest10 = number % 10;
        if (Validate3sign(number))
        {
            thirdDigit = rest10;
        }
        number /= 10;
    }
    System.Console.WriteLine($"Третья цифра числа -> {thirdDigit}");
}
else
{
    System.Console.WriteLine($"В числе {number} - третьей цифры нет!");
}

