// Напишите программу для суммирования двух
// двумерных массивов


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
    Console.WriteLine();
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

void GetSum(int[,] array1, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i, j] = array1[i, j] + array2[i, j];
        }
    }
}

int mSize = GetSize("m");
int nSize = GetSize("n");

int[,] firstArray = new int[mSize, nSize];
int[,] secondArray = new int[mSize, nSize];
int[,] result = new int[mSize, nSize];

FillArray(firstArray);
FillArray(secondArray);

PrintArray(firstArray);
PrintArray(secondArray);

GetSum(firstArray,secondArray,result);

PrintArray(result);

