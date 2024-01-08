// Напишите программу для умножения двух
// двумерных массивов (есть ограничения в размерностях)



int GetSizeArray(string name, string nameArray)
{
    Console.Write($"Введите длинну массива {name} для {nameArray} матрицы: ");
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
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

int[,] arrayA = new int[GetSizeArray("m", "A"), GetSizeArray("n", "A")];
int[,] arrayB = new int[GetSizeArray("m", "B"), GetSizeArray("n", "B")];

while (arrayA.GetLength(0) != arrayB.GetLength(1))
{
    Console.WriteLine($"Введены неправильные размерности для умножения! ");
    arrayA = new int[GetSizeArray("m", "A"), GetSizeArray("n", "A")];
    arrayB = new int[GetSizeArray("m", "B"), GetSizeArray("n", "B")];
}

int[,] arrayAB = new int[arrayA.GetLength(0),arrayB.GetLength(1)]