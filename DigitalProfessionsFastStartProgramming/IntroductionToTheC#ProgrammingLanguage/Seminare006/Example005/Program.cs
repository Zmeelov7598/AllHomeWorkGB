// Напишите программу, которая
// будет создавать копию заданного массива с
// помощью поэлементного копирования.

int GetLength()
{
    Console.Write($"Введите желаемую длинну массива : ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != arr.GetLength(0) - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }
    Console.WriteLine();
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}

void CopingArray(int[] donor, int[] recipient)
{
    for (int i = 0; i < donor.GetLength(0); i++)
    {
        recipient[i]=donor[i];
    }
}

int[] firstArray = new int[GetLength()];
int[] secondArray = new int[firstArray.GetLength(0)];
FillArray(firstArray);
PrintArray(firstArray);
CopingArray(firstArray,secondArray);
PrintArray(secondArray);