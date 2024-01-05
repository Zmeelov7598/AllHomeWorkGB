// Не используя рекурсию, выведите
// первые N чисел Фибоначчи. Первые два числа
// Фибоначчи: 0 и 1.

int GetN()
{
    Console.Write($"Введите число N : ");
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

void FillFibonachiArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == 0)
        {
            arr[i] = i;
        }
        else if (i == 1)
        {
            arr[i] = i;
        }
        else
        {
            arr[i] = arr[i - 1] + arr[i -2];
        }
    }
}

int[] fibinachiArray = new int[GetN()];

PrintArray(fibinachiArray);
FillFibonachiArray(fibinachiArray);
PrintArray(fibinachiArray);
