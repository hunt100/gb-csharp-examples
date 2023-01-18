// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Write number: ");
int num = Convert.ToInt32(Console.ReadLine());
GetSecondNumber(num);

static void GetSecondNumber(int num)
{
    if (num < 100 || num >= 1000)
    {
        Console.WriteLine($"Number {num} is out of range [100; 1000)! Exit....");
        return;
    }

    int res = num / 10 % 10;
    Console.WriteLine($"Second number of {num} is {res}");
}
