// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число : ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

if (firstUserNumber > secondUserNumber) Console.WriteLine($"MAX={firstUserNumber}");

if (firstUserNumber < secondUserNumber) Console.WriteLine($"MAX={secondUserNumber}");

if (firstUserNumber == secondUserNumber) Console.WriteLine("Введены два ОДИНАКОВЫХ числа!!");
Console.WriteLine();