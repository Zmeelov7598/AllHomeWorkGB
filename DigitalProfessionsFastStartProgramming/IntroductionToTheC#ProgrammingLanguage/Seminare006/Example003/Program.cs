// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

int GetNumber()
{
    Console.Write($"Введите число : ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetLength(int number)
{
    int length = 0;
    while (number > 0)
    {
        number /= 2;
        length++;
    }
    return length;
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

void FillArrayAnswer(int[] arr, int userNumber)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = userNumber % 2;
        userNumber /= 2;
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

int userNumber = GetNumber();
int[] answerArray = new int[GetLength(userNumber)];

PrintArray(answerArray);
FillArrayAnswer(answerArray, userNumber);
PrintArray(answerArray);
Revers(answerArray);
PrintArray(answerArray);