// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//     Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintFib(int num)
{
    int first = 0;
    int second = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{first} ");
        int temp = first + second;
        first = second;
        second = temp;
    }
}

int num = Prompt("Write a number: ");
PrintFib(num);