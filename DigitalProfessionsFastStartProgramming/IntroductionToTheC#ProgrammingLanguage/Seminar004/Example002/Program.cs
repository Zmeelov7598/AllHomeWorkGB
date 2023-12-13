// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int GetNumber()
{
    int userNumber = 0;
    Console.Write("Введите число : ");
    return userNumber = Convert.ToInt32(Console.ReadLine());
}

void GetAmmount(int userNumber)
{
    int number = userNumber;
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    Console.WriteLine($"В этом числе {count} чисел.");
}
int userNumberA = GetNumber();

GetAmmount(userNumberA);