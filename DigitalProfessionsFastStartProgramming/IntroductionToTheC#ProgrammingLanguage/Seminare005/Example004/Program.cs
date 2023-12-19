// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке
// [10,99].

void FillArrau(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(-100, 150);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        if (i != arr.GetLength(0) - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.WriteLine(arr[i]);
    Console.WriteLine();
}

void FindNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i] <= 99 && arr[i] >= 10)
            {
                count++;
            }
    }
    Console.WriteLine($"{count} чисел в интервале от 10 до 99");
}

int[] userArray = new int[123];
FillArrau(userArray);
PrintArray(userArray);
FindNumbers(userArray);