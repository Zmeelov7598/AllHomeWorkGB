// Напишите программу, которая принемает одно число и выдает таблицу квадратов до этого числа.

int GetNumber()
{
    Console.Write("Введите число : ");
    return Convert.ToInt32(Console.ReadLine());
}

void GetPrint(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.Write($"{Math.Pow(count, 2)}, ");
        count++;
    }
}

GetPrint(GetNumber());