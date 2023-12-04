// Напишите программу, котора на вход будет принемать два числа и выводить, влется ли второе число кратным первому.

Console.Write("Введите первое число : ");
int userFirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");
int userSecondNumber = Convert.ToInt32(Console.ReadLine());

void Modul(int firstNumber, int secondNumber)
{
    if (secondNumber % firstNumber == 0)
    {
        Console.WriteLine("Второе число кратно первому!");
    }

    if (secondNumber % firstNumber != 0)
    {
        Console.WriteLine($"Второе число НЕкратно первому! Остаток от деления = {secondNumber % firstNumber}");
    }
}

Modul(userFirstNumber, userSecondNumber);