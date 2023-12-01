// Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число : ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber % 2 == 0) Console.WriteLine("Это Четное число");
else Console.WriteLine("Это НЕ четное число!");
Console.WriteLine();