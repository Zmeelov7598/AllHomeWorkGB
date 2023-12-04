// Напишите прлограмму, котора на вход принимает трехзначное число и 
// на выходе показывает вторую цифру этого числа.

// ПЕРВЫЙ ВАРИАНТ РЕШЕНИЯ!!!

// Console.Write("Введите трехзначное число : ");
// Console.WriteLine((Convert.ToInt32(Console.ReadLine()) / 10) % 10);

// ВТОРОЙ ВАРИАНТ РЕШЕНИЯ!!!


// void FindSecondDigit(int number)
// {
//     Console.WriteLine((number / 10) % 10);
// }
// Console.Write("Введите трех значное число : ");
// FindSecondDigit(Convert.ToInt32(Console.ReadLine()));

// ТРЕТИЙ ВАРИАНТ РЕШЕНИЯ

void FindSecondDigit(int number)
{
    int[] array = new int[3];
    for (int i = 2; i >=0; i-- )
    {
        array[i] = number % 10;
        number/=10;
    }
    Console.WriteLine(array[1]);
}

Console.Write("Введите трех значное число : ");
FindSecondDigit(Convert.ToInt32(Console.ReadLine()));