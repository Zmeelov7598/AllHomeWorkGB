// Задайте двумерный массив. Найдите
// элементы, у которых оба индекса чётные, и
// замените эти элементы на их квадраты.

int GetSize(string name)
{
    Console.Write($"Введите размерность {name} : ");
    return Convert.ToInt32(Console.ReadLine());
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
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void SearchForEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
}

int[,] userArray = new int[GetSize("m"), GetSize("n")];

FillArray(userArray);
PrintArray(userArray);
Console.WriteLine();
SearchForEven(userArray);
PrintArray(userArray);


