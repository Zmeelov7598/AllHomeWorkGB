// Напишите программу, которая на вход принимает число А и выдает сумму чисел от 1 до А

int GetNumber()
{
    int userNumber = 0;
    Console.Write("Введите число : ");
    return userNumber = Convert.ToInt32(Console.ReadLine());

}

void GetSum(int userNumber)
{
    int sum = 0;
    for (int count = 0; count <= userNumber; count++)
    {
        sum = sum + count;
    }
    Console.WriteLine($"Сумма от 1 до {userNumber} = {sum}");
}

int userNumberA = GetNumber();
GetSum(userNumberA);
Console.WriteLine();