// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

int GetLengthArray(string name)
{
    Console.Write($"Введите количество {name} в новом массиве : ");
    return Convert.ToInt32(Console.ReadLine());
}

void GetNumberArray(int[,] array)
{
    int numberColumn = -1;
    int numberRow = -1;
    while (numberColumn > array.GetLength(1) || numberColumn < 0)
    {
        Console.Write("Введите номер столбца позиции : ");
        numberColumn = Convert.ToInt32(Console.ReadLine());
        if (numberColumn > array.GetLength(1))
        {
            Console.WriteLine("Такого элемента нет!!");
        }
    }
    while (numberRow > array.GetLength(0) || numberRow < 0)
    {
        Console.Write("Введите номер строки позиции : ");
        numberRow = Convert.ToInt32(Console.ReadLine());
        if (numberRow > array.GetLength(0))
        {
            Console.WriteLine("Такого элемента нет!!");
        }
    }
    Console.WriteLine($"Элемент с позицией {numberRow},{numberColumn} = {array[numberRow - 1, numberColumn - 1]}");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j != array.GetLength(1) - 1)
            {
                Console.Write($"{array[i, j]}, ");
            }
            else
            {
                Console.Write(array[i, j]);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] userArray = new int[GetLengthArray("строк"), GetLengthArray("столбцов")];

FillArray(userArray);
PrintArray(userArray);
GetNumberArray(userArray);