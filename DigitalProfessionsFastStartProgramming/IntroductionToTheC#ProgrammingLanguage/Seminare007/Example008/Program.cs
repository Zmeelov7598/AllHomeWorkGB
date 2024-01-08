// Напишите программу для умножения массива
// различных размерностей на число

int GetSizeArray(string name)
{
    Console.Write($"Введите длинну массива {name} : ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j != array.GetLength(1) - 1)
            {
                Console.Write($"{array[i, j]}, ");
            }
            else
            {
                Console.Write(array[i, j]);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplayingByNumber(int[,] array)
{
    int userNumber = 0;
    Console.Write($"Введите число для умножения матрицы : ");
    userNumber = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] *= userNumber;
        }
    }
}

void FillArray(int[,] array)
{
    for(int i =0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
}

int[,] userArray = new int[GetSizeArray("m"), GetSizeArray("n")];

FillArray(userArray);
PrintArray(userArray);
MultiplayingByNumber(userArray);
PrintArray(userArray);