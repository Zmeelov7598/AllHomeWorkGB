// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

int GetLength()
{
    Console.Write($"Введите желаемую длинну массива : ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        if (i != arr.GetLength(0) - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write(arr[i]);
    Console.WriteLine();
}

void FillArray(double[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        arr[i] = new Random().Next(1, 100);
}

void DifferenceMaxMin(double[] arr)
{
    double maxNumber = arr[0];
    double minNumber = arr[0];
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (arr[i] > maxNumber)
            maxNumber = arr[i];
        if (arr[i] < minNumber)
            minNumber = arr[i];
    }
    Console.Write($"Разница между максимальным числом {maxNumber} и минимальным числом {minNumber} =  {Math.Abs(maxNumber - minNumber)}");
}

double[] userArray = new double[GetLength()];
FillArray(userArray);
PrintArray(userArray);
DifferenceMaxMin(userArray);
