int Max(int arq1, int arq2, int arq3)
{
    int result = arq1;
    if (arq2 > result) result = arq2;
    if (arq3 > result) result = arq3;
    return result;
}

int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[6], array[8]));
Console.WriteLine(max);