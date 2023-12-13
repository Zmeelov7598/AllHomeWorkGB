// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

void PrintMassive(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == array.GetLength(0) - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(0,2);
    }
}

int[] userMassive = new int[8];

PrintMassive(userMassive);
FillArray(userMassive);
PrintMassive(userMassive);
