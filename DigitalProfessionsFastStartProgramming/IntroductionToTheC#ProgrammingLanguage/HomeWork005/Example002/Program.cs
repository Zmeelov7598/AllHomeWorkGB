// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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
        arr[i] = new Random().Next(100, 1000);
}

void GetSumEven(int[] arr)
{
    int sumEver = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if ((i + 1) % 2 == 0)
            sumEver += arr[i];
    }
    Console.WriteLine($"Сумма чисел стоящих на четных ппозициях равна {sumEver}");
}

int[] userArray = new int[GetLength()];

FillArray(userArray);
PrintArray(userArray);
GetSumEven(userArray);
