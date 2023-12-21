// Напишите программу, которая
// перевернёт одномерный массив (последний
// элемент будет на первом месте, а первый -
// на последнем и т.д.)

int GetLength()
{
    Console.Write($"Введите желаемую длинну массива : ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        if (i != arr.GetLength(0) - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write(arr[i]);
    Console.WriteLine();
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

void Revers(int[] arr)
{
    int tempNumber = 0;
    if (arr.GetLength(0) % 2 == 0)
    {
        for (int i = 0; i < arr.GetLength(0) / 2; i++)
        {
            tempNumber = arr[arr.GetLength(0) - i - 1];
            arr[arr.GetLength(0) - i - 1] = arr[i];
            arr[i] = tempNumber;
        }
    }
    else
    {
        for (int i = 0; i < (arr.GetLength(0) / 2) + 1; i++)
        {
            tempNumber = arr[arr.GetLength(0) - i - 1];
            arr[arr.GetLength(0) - i - 1] = arr[i];
            arr[i] = tempNumber;
        }
    }
}

int[] userArray = new int[GetLength()];

FillArray(userArray);
PrintArray(userArray);
Revers(userArray);
PrintArray(userArray);