// // Напишите программу для деления двух
// // двумерных массивов.

// // Считает матрицы 2 на 2

// int GetLengthArray(string name, string array)
// {
//     Console.Write($"Введите количество {name} матрицы {array} : ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j != array.GetLength(1) - 1)
//             {
//                 Console.Write($"{array[i, j]}, ");
//             }
//             else
//             {
//                 Console.Write(array[i, j]);
//             }
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int GetDeterminate(int[,] array)
// {
//     int count1 = 0;
//     int count2 = array.GetLength(1) - 1;
//     int sum1 = 1;
//     int sum2 = 1;
//     while (count1 <= array.GetLength(1) - 1)
//     {
//         sum1 *= array[count1, count1];
//         sum2 *= array[count2, count1];
//         count1++;
//         count2--;
//     }
//     int result = sum1 - sum2;
//     return result;
// }


// int[,] arrayA = new int[GetLengthArray("строк", "A"), GetLengthArray("столбцов", "A")];
// int[,] arrayB = new int[GetLengthArray("строк", "B"), GetLengthArray("столбцов", "B")];

// if (arrayB.GetLength(0) != arrayB.GetLength(1))
// {
//     Console.WriteLine("Матрица В Должна быть квадратной!!!");
//     Console.WriteLine();
//     return;
// }

// if (arrayA.GetLength(1) != arrayB.GetLength(0))
// {
//     Console.WriteLine("Количество столбцов матрицы А не равно количеству строк матрицы В");
//     Console.WriteLine();
//     return;
// }

// FillArray(arrayA);
// FillArray(arrayB);

// if (GetDeterminate(arrayB) == 0)
// {
//     Console.WriteLine("Определитель матрицы B равен 0. решение не определено!!!");
//     Console.WriteLine();
// }

// int[,] arrayMinor = new int[arrayA.GetLength(0), arrayA.GetLength(1)];

// PrintArray(arrayA);
// PrintArray(arrayB);

// // ДОДЕЛАТЬ ДЕЛЕНИЕ!!!!!!!!!!!!!

//Реализовать метод деления одного двумерного массива на другой

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetRandomValue(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m, n];
}

int GetDeterminate2x2(int[,] minor)
{
    return minor[0, 0] * minor[1, 1] - minor[0, 1] * minor[1, 0];
}

int GetDeterminate3x3(int[,] arr)
{
    return 3; //нужна верная формула
}

//метод, возращающий массив 2х2 из массива 3х3, в котором удалены строки и столбцы по индексам
int[,] DeleteLines(int[,] arr, int posRow, int posColumn)
{
    int k = 0, l = 0;
    int[,] resultArr = new int[2, 2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != posRow)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != posColumn)
                {
                    resultArr[k, l] = arr[i, j];
                    l++;
                }
            }
            l = 0;
            k++;
        }
    }
    return resultArr;
}

int[,] GetMassivOfMinors(int[,] arr)
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            resultArr[i, j] = Convert.ToInt32(Math.Pow(-1, i + j)) * GetDeterminate2x2(DeleteLines(arr, i, j));
        }
    }
    Console.WriteLine("GetMassivOfMinors");
    PrintArray(resultArr);
    return resultArr;
}


int[,] GetTranspositionMassiv(int[,] arr)
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            resultArr[j, i] = arr[i, j];
        }
    }
    Console.WriteLine("GetTranspositionMassiv");
    PrintArray(resultArr);
    return resultArr;
}

int[,] GetMultiMassivAndChislo(int[,] arr, int number)
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            resultArr[j, i] = number * arr[i, j]; //нужно делить 
        }
    }
    Console.WriteLine("GetMultiMassivAndChislo");
    PrintArray(resultArr);
    return resultArr;
}

int[,] GetMultiArrays(int[,] array1, int[,] array2)
{
    int[,] mult = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            mult[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                mult[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    Console.WriteLine("GetMultiArrays");
    PrintArray(mult);
    return mult;
}

int[,] GetReverseArray(int[,] arr)
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)];

    resultArr = GetMultiMassivAndChislo(GetTranspositionMassiv(GetMassivOfMinors(arr)),
                                    GetDeterminate3x3(arr));
    return resultArr;

}

int[,] GetDivision(int[,] arrNom, int[,] arrDenom)
{
    return GetMultiArrays(arrNom, GetReverseArray(arrDenom));
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array1 = InitializateArray(m, n);
int[,] array2 = InitializateArray(m, n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array1, minValue, maxValue);
FillArray(array2, minValue, maxValue);

PrintArray(array1);

PrintArray(DeleteLines(array1, 1, 1));

if ((m == 3) && (n == 3))
    PrintArray(GetDivision(array1, array2));