// Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и
// положительных элементов массива.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
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

void SearchSumm(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i] < 0)
        {
            sumNegative +=arr[i];
        }
        if (arr[i] > 0)
        {
            sumPositive +=arr[i];
        }
    }
    Console.WriteLine($"Сумма положительных = {sumPositive}");
    Console.WriteLine($"Сумма отрицательных = {sumNegative}");
}

int[] userArray = new int[12];

PrintArray(userArray);
FillArray(userArray);
PrintArray(userArray);
SearchSumm(userArray);
