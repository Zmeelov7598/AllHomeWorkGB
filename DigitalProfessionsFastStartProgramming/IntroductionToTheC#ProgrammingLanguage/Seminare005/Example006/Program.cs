// : Задайте массив. Напишите программу, которая выводит
// индексы всех элементов, равных заданному числу в массиве.

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != arr.GetLength(0) - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write(arr[i]);
    }
    Console.WriteLine();
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

void FindNumber(int[] arr, int userNumber)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i] == userNumber)
        {
            Console.WriteLine($"Число расположено в массиве под индексом {i} .");
            Console.WriteLine();
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine($"числа {userNumber} нет в массиве!");
    }
}

int[] userArray = new int[5];
FillArray(userArray);
PrintArray(userArray);
FindNumber(userArray, 1);
