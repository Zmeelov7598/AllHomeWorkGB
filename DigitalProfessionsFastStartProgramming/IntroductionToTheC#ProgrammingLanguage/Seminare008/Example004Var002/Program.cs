
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

void ArrangeArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < rows; k++)
            {
                for (int l = 0; l < cols; l++)
                {
                    if (matrix[i, j] < matrix[k, l])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[k, l];
                        matrix[k, l] = temp;
                    }
                }
            }
        }
    }
}


void FR(int[,] array)
{
    Dictionary<int, int> freqDictionary = new Dictionary<int, int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int element = array[i, j];

            if (freqDictionary.ContainsKey(element))
            {
                freqDictionary[element]++;
            }
            else
            {
                freqDictionary.Add(element, 1);
            }
        }
    }

    foreach (var kvp in freqDictionary)
    {
        Console.WriteLine($"Элемент {kvp.Key} встречается {kvp.Value} раз(а)");
    }

    Console.WriteLine();
}

int[,] userArray = new int[GetArrayLength("строк"), GetArrayLength("столбцов")];
int[] arrangeArray = new int[userArray.GetLength(0) * userArray.GetLength(1)];
FillArray(userArray);
PrintArrayTwoDimensional(userArray);
ArrangeArray(userArray);
PrintArrayTwoDimensional(userArray);
FR(userArray);


