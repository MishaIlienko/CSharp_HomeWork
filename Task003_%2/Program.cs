// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число!");
string inputed = Console.ReadLine();
int num = Convert.ToInt32(inputed);
if (num % 2 == 0)
{
    Console.WriteLine("Ваше число является четным");
}
else
{
    Console.WriteLine("Ваше число НЕ является четным!");
}
