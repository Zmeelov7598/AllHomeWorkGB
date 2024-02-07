//  Задайте двумерный массив. 
// Напишите программу, которая заменяет строки 
// на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для 
// пользователя.

int GetArrayLength(string name)
{
    Console.Write($"Введите количество {name} в матрице : ");
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

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void ChangRowColumn(int[,] array)
{
    int[,] changeArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            changeArray[j, i] = array[i, j];
        }
    }
    PrintArray(changeArray);
}

int[,] userArray = new int[GetArrayLength("строк"), GetArrayLength("столбцов")];
while (userArray.GetLength(0) != userArray.GetLength(1))
{
    Console.WriteLine("Матрица должна быть квадратной");
    userArray = new int[GetArrayLength("строк"), GetArrayLength("столбцов")];
}
FillArray(userArray);
PrintArray(userArray);
ChangRowColumn(userArray);

