// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Write number: ");
int num = Convert.ToInt32(Console.ReadLine());
GetThirdDigit(num);

static void GetThirdDigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine($"There is no third digit");
        return;
    }

    while (num >= 1000)
    {
        num /= 10;
    }
    
    Console.WriteLine($"Third digit is {num % 10}");
}
