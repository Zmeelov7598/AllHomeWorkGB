//  Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(0, 5);
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

void FindNumbers(int[] arr, int number)
{
    int count=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i] == number)
        {
            count++;
        }

    }
    Console.WriteLine($"Число {number} присутствует {count} раз.");
}

int[] userArray = new int[5];
PrintArray(userArray);
FillArray(userArray);
PrintArray(userArray);
FindNumbers(userArray,3);