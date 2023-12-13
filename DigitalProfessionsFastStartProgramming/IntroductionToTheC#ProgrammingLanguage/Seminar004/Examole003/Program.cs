// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int GetNumber()
{
    Console.Write("Введите число : ");
    int userNumber = 0;
    return userNumber = Convert.ToInt32(Console.ReadLine());
}

void NumberMult(int userNumber)
{
    int sumMult = 1;
    for (int i = 1; i <= userNumber; i++)
    {
        sumMult = sumMult * i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {userNumber} = {sumMult}");
}

int userNumberA = GetNumber();
NumberMult(userNumberA);