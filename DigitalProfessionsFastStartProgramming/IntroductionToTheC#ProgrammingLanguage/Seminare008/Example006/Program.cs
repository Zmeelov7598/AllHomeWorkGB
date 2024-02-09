// Написать рекурсивный метод, проверяющий равенство 
// сумм цифр одного числа и второго числа

int GetNumber()
{
    Console.Write($"Введите число : ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int number)
{
    if (number < 10) return number;
    else return number % 10 + GetSum(number / 10);
}
void CheckSum(int a, int b)
{
    if (a == b)
    {
        Console.Write($"Сумма цифр первого числа РАВНА сумме цифр второго числа ");
    }
    if (a != b)
    {
        Console.Write($"Сумма цифр первого числа НЕ равна сумме цифр второго числа ");
    }
}


CheckSum(GetSum(GetNumber()), GetSum(GetNumber()));


