//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetNumber()
{
    int userNumber = 0;
    Console.Write("Введите число : ");
    return userNumber = Convert.ToInt32(Console.ReadLine());
}

void GetSumm(int uN)
{
    int result = 0;
    int temp = uN;
    while (temp > 0)
    {
        result = result + (temp % 10);
        temp /= 10;
    }
    Console.WriteLine(result);
    Console.WriteLine();
}

int userNumber = GetNumber();
GetSumm(userNumber);
