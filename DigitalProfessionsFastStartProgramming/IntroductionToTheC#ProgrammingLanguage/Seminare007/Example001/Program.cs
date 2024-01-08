// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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
            array[i,j] = new Random().Next(0,100);
        }
    }
}

int[,] userArray = new int[GetSize("m"), GetSize("n")];

FillArray(userArray);
PrintArray(userArray);

