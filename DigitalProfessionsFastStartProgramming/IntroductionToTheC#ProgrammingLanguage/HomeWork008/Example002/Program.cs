// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int GetArrayLength(string name)
{
    Console.Write($"Введите количество {name} в матрице : ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArrayOneDimensional(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == array.GetLength(0) - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine();
}

void PrintArrayTwoDimensional(int[,] array)
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

void GetSumRow(int[,] array, int[] sum)
{
    int tempSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
            if (j == array.GetLength(1) - 1)
            {
                sum[i] = tempSum;
                tempSum = 0;
            }
        }
    }
}

void FindMin(int[] sum)
{
    int number = 1;
    int min = sum[0];
    for (int i = 1; i < sum.GetLength(0); i++)
    {
        if (min > sum[i])
        {
            min = sum[i];
            number = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой под №{number}!");
}

int[,] userArray = new int[GetArrayLength("строк"), GetArrayLength("столбцов")];

while (userArray.GetLength(0) == userArray.GetLength(1))
{
    Console.WriteLine("Матрица должна быть прямоугольной!!!");
    userArray = new int[GetArrayLength("строк"), GetArrayLength("столбцов")];
}

int[] arraySum = new int[userArray.GetLength(0)];
FillArray(userArray);
PrintArrayTwoDimensional(userArray);
GetSumRow(userArray, arraySum);
PrintArrayOneDimensional(arraySum);
FindMin(arraySum);
