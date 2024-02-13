// Задайте значения M и N. Напишите программу,
// которая найдет сумму натуральных элементов в промежутке от M до N

double SumFor(double firstNumber, double lastNumber)
{
    double result = 0;
    if (firstNumber < lastNumber)
    {
        result = firstNumber + SumFor(firstNumber + 1, lastNumber);
    }
    else if (firstNumber == lastNumber)
    {
        result = result + lastNumber;
    }
    return result;
}

double GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double m = Math.Ceiling(GetNumber("Введите число M : "));
double n = Math.Truncate(GetNumber("Введите число N : "));
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SumFor(m, n)}");