// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber()
{
    Console.Write("Введите число : ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void GetCube(int number)
{

    for (int count = 1; count <= number; count++)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
    }
}

int number = GetNumber();
GetCube(number);
