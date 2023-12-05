// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

void Change(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Число кратно 7 и 23 !");
    }
    else Console.WriteLine("НЕТ кратности 7 и 23 !");
}
Console.Write("Введите число : ");
Change(Convert.ToInt32(Console.ReadLine()));
