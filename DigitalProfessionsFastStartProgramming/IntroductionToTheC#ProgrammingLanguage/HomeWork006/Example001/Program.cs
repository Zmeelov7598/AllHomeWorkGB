// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// ВАРИАНТ №1

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");

int GetLength()
{
    Console.Write($"Сколько чисел вы планируете ввести: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        if (i != arr.GetLength(0) - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write(arr[i]);
    Console.WriteLine();
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Введите {i+1} число :");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Введено {count} положительных чисел");
}

int[] userNumbers = new int[GetLength()];

FillArray(userNumbers);
PrintArray(userNumbers);
CountPositive(userNumbers);