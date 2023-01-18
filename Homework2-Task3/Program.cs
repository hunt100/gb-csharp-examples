// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Write number(DayOfWeek): ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Is {num} a holiday day of week ? {IsDayOff(num)}");

static bool IsDayOff(int num)
{
    if (num < 1 || num > 7)
    {
        throw new ArgumentException("Day of week must be number between 1 and 7");
    }

    return num >= 6;
}