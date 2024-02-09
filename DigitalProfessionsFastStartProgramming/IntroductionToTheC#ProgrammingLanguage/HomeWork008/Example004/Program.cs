// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int GetLengthArray()
{
    Console.Write("Введите желаемы размер квадратной матрицы : ");
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

void GetFillSpiral(int[,] arr, int n)
{
    int count = 1;
    for (int delta = 0; delta < n - 2; delta++)
    {
        for (int j = 0 + delta; j < arr.GetLength(1) - delta; j++)
        {
            arr[0 + delta, j] = count;
            count++;
        }
        count--;
        for (int k = 0 + delta; k < arr.GetLength(1) - delta; k++)
        {
            arr[k, n - 1 - delta] = count;
            count++;
        }
        count--;
        for (int l = n - 1 - delta; l >= 0 + delta; l--)
        {
            arr[n - 1 - delta, l] = count;
            count++;
        }
        count--;
        for (int m = n - 1 - delta; m >= 1 + delta; m--)
        {
            arr[m, 0 + delta] = count;
            count++;
        }
    }
}

int range = GetLengthArray();
int[,] array = new int[range, range];


GetFillSpiral(array, array.GetLength(0));
PrintArray(array);