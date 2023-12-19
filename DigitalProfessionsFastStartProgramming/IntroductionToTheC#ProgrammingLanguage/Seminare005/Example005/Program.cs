// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int LengthArray()
{
    Console.Write($"Введите желаемую длинну массива : ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        arr[i] = new Random().Next(1, 10);
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

int GetNewLength(int length)
{
    int newLength = 0;
    if (length % 2 == 0)
    {
        return newLength = length / 2;
    }
    else return newLength = (length / 2) + 1;
}

void GetAnswer(int[] arr, int[] answer)
{
    int count = 1;
    for (int j = 0; j < answer.GetLength(0); j++)
    {
        if (j == (arr.GetLength(0) - count))
        {
            answer[j] = arr[j];
            break;
        }
        else 
        {answer[j] = arr[j] * arr[arr.GetLength(0) - count];
        count++;
        }

    }

}

int[] userArray = new int[LengthArray()];
FillArray(userArray);
PrintArray(userArray);
int[] answer = new int[GetNewLength(userArray.GetLength(0))];
PrintArray(answer);
GetAnswer(userArray,answer);
PrintArray(answer);
