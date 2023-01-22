// Задача 19
// Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool isPalindromeStr(string str)
{
    return str == new string(str.Reverse().ToArray());
}

bool isPalindromeNum(int num)
{
    int initialNum = num;
    int reverse = 0;
    while (num != 0)
    {
        reverse = reverse * 10 +  num % 10;
        num /= 10;
    }

    return initialNum == reverse;
}

int num = Prompt("Write your num:");

Console.WriteLine($"{num} is palindrome: {isPalindromeNum(num)}");
Console.WriteLine($"{num} is palindrome: {isPalindromeStr(num.ToString())}");
