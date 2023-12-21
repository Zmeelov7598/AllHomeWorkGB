// Напишите программу, которая
// принимает на вход три числа и проверяет, может
// ли существовать треугольник с сторонами такой
// длины.

int GetNumber(string number)
{
    Console.Write($"Введите {number} число : ");
    return Convert.ToInt32(Console.ReadLine());
}

void CheckTriangle(int firstSide, int secondSide, int thredSide)
{
    if (firstSide >= secondSide + thredSide)
    {
        Console.WriteLine($"Такого треугольника быть не может!");
    }
    else if (secondSide >= firstSide + thredSide)
    {
        Console.WriteLine($"Такого треугольника быть не может!");
    }
    else if (thredSide >= firstSide + secondSide)
    {
        Console.WriteLine($"Такого треугольника быть не может!");
    }
    Console.WriteLine($"Треугольник с такими сторонами может существовать!");
}

int userNumberOne = GetNumber("первое");
int userNumberTwo = GetNumber("второе");
int userNumberThree = GetNumber("третье");
CheckTriangle(userNumberOne, userNumberTwo, userNumberThree);



// ВАРИАНТ №2
// Напишите программу которая принемает 
// на вход два числа и проверяет
// может ли существовать треугольник со сторонами такой длинны.

// Сумма двух других сторон должна быть больше третей. так для всех

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} число");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }
// void CheckArray(int[] arr)
// {
//     int max = arr[0];
//     int indMax = 0;
//     int sum = 0;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] > max)
//         {
//             max = arr[i];
//             indMax = i;
//             sum = sum + arr[i];
//         }
//     }
//     sum = sum -arr[indMax];
//     if (arr[indMax] < sum)
//     {
//         Console.WriteLine("Такой треугольник может существовать");
//     }
//      else
//     {
//         Console.WriteLine("Такой треугольник не может существовать");
//     }
    
// }

// int[] array = new int[3];
// FillArray(array);
// CheckArray(array);