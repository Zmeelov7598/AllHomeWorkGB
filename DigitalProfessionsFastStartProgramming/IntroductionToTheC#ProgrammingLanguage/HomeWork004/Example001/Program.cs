// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetNumber(string name)
{
    int userNumber = 0;
    Console.Write($"Введите число {name} : ");
    return userNumber = Convert.ToInt32(Console.ReadLine());
}

void Multiplay(int a, int b)
{
    int result = a;
    for (int i = 2; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

int numberA = GetNumber("A");
int numberB = GetNumber("B");

Multiplay(numberA, numberB);