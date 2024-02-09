//  Вывести первые N строк треугольника 
// Паскаля. Сделать вывод в виде равнобедренного 
// треугольника

int GetLenthPascal()
{
    Console.WriteLine("Введите число строк треугольника Паскаля : ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetFactorial(int number)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
        factorial *= i;
    return factorial;
}

void GetPascal(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= (n - i); j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write($"{GetFactorial(i) / (GetFactorial(j) * GetFactorial(i - j))} ");
        }
        Console.WriteLine();
    }
}

GetPascal(GetLenthPascal());