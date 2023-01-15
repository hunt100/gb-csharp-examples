// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Write your firstNumber: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write your secondNumber: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber > secondNumber ? firstNumber : secondNumber;
Console.WriteLine($"max = {max}");