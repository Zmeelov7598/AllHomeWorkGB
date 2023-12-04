// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

void SerchWeekends(int number)
{
    if (number >= 1 && number <= 5)
    {
        Console.WriteLine("НЕТ! Рабочий день!");
    }
    if (number == 6 || number == 7)
    {
        Console.WriteLine("ДА!! Выходной день!");
    }
    else if (number < 1 || number > 7)
    {
        Console.WriteLine("\nВведено некоректное значение!\nВведите число обозначающее день недели от 1 до 7 ");
    }
}

Console.Write("Введите число обозначающее день недели : ");
SerchWeekends(Convert.ToInt32(Console.ReadLine()));