// Составить частотный словарь 
// элементов двумерного массива. Частотный 
// словарь содержит информацию о том, сколько 
// раз встречается элемент входных данных

int GetArrayLength(string name)
{
    Console.Write($"Введите количество {name} в матрице : ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArrayTwoDimensional(int[,] array)
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

void PrintArrayOneDimensional(int[] array)
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

void CopingArray(int[,] copy, int[] past)
{
    int position = 0;
    for (int i = 0; i < copy.GetLength(0); i++)
    {
        for (int j = 0; j < copy.GetLength(1); j++)
        {
            past[position] = copy[i, j];
            position++;
        }
    }
}

void GetArrangeArray(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = (i + 1); j < array.GetLength(0); j++)
        {
            if (array[j] < array[i])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void FrequencyDictionary(int[] array)
{
    int position = 0;
    int count = 1;
    while (position < array.GetLength(0))
    {
        if (position == array.GetLength(0) - 1)
        {
            Console.WriteLine($"Число {array[position]} встречается {count} раз");
            break;
        }
        if (array[position] == array[position + 1])
        {
            count++;
            position++;
        }
        else if (array[position] != array[position + 1])
        {
            Console.WriteLine($"Число {array[position]} встречается {count} раз");
            count = 1;
            position++;
        }
    }
}



int[,] userArray = new int[GetArrayLength("строк"), GetArrayLength("столбцов")];
int[] arrangeArray = new int[userArray.GetLength(0) * userArray.GetLength(1)];
FillArray(userArray);
PrintArrayTwoDimensional(userArray);
CopingArray(userArray, arrangeArray);
PrintArrayOneDimensional(arrangeArray);
GetArrangeArray(arrangeArray);
PrintArrayOneDimensional(arrangeArray);
FrequencyDictionary(arrangeArray);

