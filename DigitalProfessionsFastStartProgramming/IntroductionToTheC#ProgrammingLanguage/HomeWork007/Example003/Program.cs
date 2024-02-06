// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int GetArrayLength(string name)
{
    Console.Write($"Введите количество {name} в матрице : ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[,] array)
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

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void ArithmeticMean(double[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.Write($"Столбец {i + 1} = {sum / array.GetLength(0)}");
        Console.WriteLine();
    }
}

double[,] userArray = new double[GetArrayLength("строк"), GetArrayLength("столбцов")];

FillArray(userArray);
PrintArray(userArray);
ArithmeticMean(userArray);