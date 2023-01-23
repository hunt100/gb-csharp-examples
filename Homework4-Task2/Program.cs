// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetDigitSum(int num)
{
    int res = 0;
    while (num != 0)
    {
        int reminder = num % 10;
        res += reminder;
        num /= 10;
    }

    return res;
}

int num = Prompt("Write down the number:");
Console.WriteLine($"{num} -> {GetDigitSum(num)}");
