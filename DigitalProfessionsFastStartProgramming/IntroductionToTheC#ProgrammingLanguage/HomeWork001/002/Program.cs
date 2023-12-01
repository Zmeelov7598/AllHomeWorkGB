// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число : ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число : ");
int thresometUserNumber = Convert.ToInt32(Console.ReadLine());

int max = firstUserNumber;

while (max < secondUserNumber || max < thresometUserNumber)
{
    if (secondUserNumber > max) max = secondUserNumber;
    if (thresometUserNumber > max) max = thresometUserNumber;
}

Console.WriteLine($"Максимально число это {max}");




// Второй вариант
// Console.WriteLine("Введите первое число!");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число!");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число!");
// int c = Convert.ToInt32(Console.ReadLine());
// int Max = a;
// if (b > Max)
// {
//     Max = b;
// }
// else if (c > Max)
// {
//     Max = c;
// }
// Console.WriteLine($"Max={Max}");