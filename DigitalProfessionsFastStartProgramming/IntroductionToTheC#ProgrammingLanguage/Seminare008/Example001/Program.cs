// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

int GetArrayLength(string name)
{
    Console.Write($"Введите количество {name} в матрице : ");
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

void GetReplacement(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[array.GetLength(0) - 1, j];
            array[array.GetLength(0) - 1, j] = temp;
        }
    }
}

int[,] userArray = new int[GetArrayLength("строк"), GetArrayLength("столбцов")];

FillArray(userArray);
PrintArray(userArray);
GetReplacement(userArray);
PrintArray(userArray);