// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetNumber()
{
    Console.Write("Введите 5-ти значное число : ");

    int userNumber = Convert.ToInt32(Console.ReadLine());

    while (userNumber < 9999 || userNumber > 99999)
    {
        Console.WriteLine("Вы Ввели не 5-ти значное число!!");
        Console.WriteLine();
        Console.Write("Введите 5-ти значное число : ");
        userNumber = Convert.ToInt32(Console.ReadLine());
    }

    return userNumber;
}

void CheckPalindrom(int number)
{
    int reverNumber = 0;
    int userNumber = number;
    while (reverNumber <= 9999)
    {
        int ost = userNumber % 10;
        reverNumber = (reverNumber * 10) + ost;
        userNumber = userNumber / 10;
    }
    if (reverNumber == number)
    {
        Console.WriteLine("Да это палиндром! ");
    }
    else
    {
        Console.WriteLine("НЕТ это не палиндром! ");
    }
}


int userNumber = GetNumber();

CheckPalindrom(userNumber);