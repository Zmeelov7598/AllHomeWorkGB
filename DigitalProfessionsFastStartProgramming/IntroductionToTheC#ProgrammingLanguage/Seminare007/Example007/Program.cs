// Напишите программу для деления двух
// двумерных массивов.

// Считает матрицы 2 на 2

int GetLengthArray(string name, string array)
{
    Console.Write($"Введите количество {name} матрицы {array} : ");
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

int GetDeterminate(int[,] array)
{
    int count1 = 0;
    int count2 = array.GetLength(1) - 1;
    int sum1 = 1;
    int sum2 = 1;
    while (count1 <= array.GetLength(1) - 1)
    {
        sum1 *= array[count1, count1];
        sum2 *= array[count2, count1];
        count1++;
        count2--;
    }
    int result = sum1 - sum2;
    return result;
}

int[,] arrayA = new int[GetLengthArray("строк", "A"), GetLengthArray("столбцов", "A")];
int[,] arrayB = new int[GetLengthArray("строк", "B"), GetLengthArray("столбцов", "B")];

if (arrayB.GetLength(0) != arrayB.GetLength(1))
{
    Console.WriteLine("Матрица В Должна быть квадратной!!!");
    Console.WriteLine();
    return;
}

if (arrayA.GetLength(1) != arrayB.GetLength(0))
{
    Console.WriteLine("Количество столбцов матрицы А не равно количеству строк матрицы В");
    Console.WriteLine();
    return;
}

FillArray(arrayA);
FillArray(arrayB);

if (GetDeterminate(arrayB) == 0)
{
    Console.WriteLine("Определитель матрицы B равен 0. решение не определено!!!");
    Console.WriteLine();
}

PrintArray(arrayA);
PrintArray(arrayB);
