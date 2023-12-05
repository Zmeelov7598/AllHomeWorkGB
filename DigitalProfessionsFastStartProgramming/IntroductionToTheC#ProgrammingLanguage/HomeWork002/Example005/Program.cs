//  Напишите программу, которая принимает на вход два числа и проверяет, является ли
// одно число квадратом другого.

void ChangeSq(int a, int b)
{
    if (a==b*b || b==a*a) Console.WriteLine("Одно число квадрат другого");
    else Console.WriteLine("ниодно число не влется квадратом другого");
}

Console.Write("Введите Первое число : ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число : ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

ChangeSq(firstUserNumber, secondUserNumber);