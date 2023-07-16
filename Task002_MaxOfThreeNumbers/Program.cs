// Задача 2: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число!");
string input1 = Console.ReadLine();
int num1 = Convert.ToInt32(input1);
Console.WriteLine("Введите второе число!");
string input2 = Console.ReadLine();
int num2 = Convert.ToInt32(input2);
Console.WriteLine("Введите третье число!");
string input3 = Console.ReadLine();
int num3 = Convert.ToInt32(input3);
int max =num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
//if (num3 > num1) max = num3;
Console.WriteLine($"Максимальное число {max}!");
