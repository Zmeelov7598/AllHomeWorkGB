// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int GetLength()
{
    Console.Write($"Введите желаемую длинну массива : ");
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
        arr[i] = new Random().Next(100, 1000);
}

void ChekingNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    if (count == 0)
        Console.WriteLine($"В данном массиве нет четных чисел!");
    else    
        Console.WriteLine($"В данном массиве {count} четных чисед!");
}

int[] userArray = new int[GetLength()];

FillArray(userArray);
PrintArray(userArray);
ChekingNumbers(userArray);