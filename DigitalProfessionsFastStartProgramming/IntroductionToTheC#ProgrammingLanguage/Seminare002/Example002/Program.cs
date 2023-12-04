// Напишите программу, котора выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int DelSecondPos(int number)
{
    int threNumber = number % 10;
    int firstNumber = number/100;
    return (firstNumber * 10) + threNumber;

}

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine(randomNumber);

Console.WriteLine(DelSecondPos(randomNumber));

