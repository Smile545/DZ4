// // Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

// // 452 -> 11

// // 82 -> 10

// // 9012 -> 12

Console.Write("Введите число ");
int а = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (а != 0)
{
    result += а % 10;
    а /= 10;
    }
Console.WriteLine(result);

