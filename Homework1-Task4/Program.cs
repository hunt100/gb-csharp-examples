// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Write your end range number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Wrong input. Number must be 1 or greater!");
}
else
{
    Console.Write($"Even numbers in range: 1 - {num}: ");
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}