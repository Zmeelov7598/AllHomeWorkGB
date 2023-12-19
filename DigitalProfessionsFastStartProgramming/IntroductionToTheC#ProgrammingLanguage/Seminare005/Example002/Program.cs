//  Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и
// наоборот.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(-10, 11);
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

void ReplacmentNumbers(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] *= -1;
    }

}

int[] userArray = new int[10];
PrintArray(userArray);
FillArray(userArray);
PrintArray(userArray);
ReplacmentNumbers(userArray);
PrintArray(userArray);

