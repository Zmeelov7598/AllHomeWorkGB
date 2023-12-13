// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int GetLengthArray()
{
    int len = 0;
    Console.Write("Введите желаемую длинну массива : ");
    return len = Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] uA)
{
    for (int i = 0; i < uA.GetLength(0); i++)
    {
        if (i != uA.GetLength(0) - 1)
        {
            Console.Write($"{uA[i]}, ");
        }
        else
        {
            Console.Write(uA[i]);
        }
    }
}

int[] arrayUser = new int[GetLengthArray()];
FillArray(arrayUser);
PrintArray(arrayUser);


