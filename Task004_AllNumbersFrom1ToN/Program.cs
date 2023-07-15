// Задача 4: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число!");
string input = Console.ReadLine();
int num = Convert.ToInt32(input);
int x = 2;
while (x <= num)
{
    Console.Write($" {x}");
    x+=2;
}