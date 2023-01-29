// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintAsBinaryNum(int num)
{
    string binStr = "";
    if (num == 0)
    {
        Console.WriteLine("0");
        return;
    }
    
    while (num > 0)
    {
        int reminder = num % 2;
        binStr += reminder;
        num /= 2;
    }

    Console.WriteLine($"Own bin: {new string(binStr.Reverse().ToArray())}");
}

int num = Prompt("Write a number: ");
Console.WriteLine($"binary: {Convert.ToString(num, 2)}");
PrintAsBinaryNum(num);