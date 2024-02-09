// Написать рекурсивный метод, рассчитывающий 
// количество делителей числа.

int GetNumber()
{
    Console.Write($"Введите число :");
    return Convert.ToInt32(Console.ReadLine());
}

void GetDivisors(int number, int divisors, int count)
{
    if (number % divisors == 0)
    {
        count++;
    }
    if (divisors < number)
    {
        GetDivisors(number, divisors + 1, count);
    }

    if (divisors == number)
    {
        Console.WriteLine(count);
    }

}

GetDivisors(GetNumber(), 1, 0);
