//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число!");
string input = Console.ReadLine();
int num = Convert.ToInt32(input);
Console.WriteLine("Введите второе число!");
string input1 = Console.ReadLine();
int num1 = Convert.ToInt32(input1);
if (num == num1)
{
    Console.WriteLine("Оба числа равны!");
}
if (num > num1)
{
Console.WriteLine($"Max = {num}");
Console.WriteLine($"Min = {num1}");
}
if (num1 > num)
{
Console.WriteLine($"Max = {num1}");
Console.WriteLine($"Min = {num}");
}
