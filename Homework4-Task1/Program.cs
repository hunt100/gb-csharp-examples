// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

double Pow(double num, double degree)
{
    double result = 1.0;
    for (int i = 0; i < degree; i++)
    {
        result *= num;
    }

    return result;
}

double num = Prompt("Write down the number:");
double degree = Prompt("Write down the number degree:");
Console.WriteLine($"({num})^{degree} = {Pow(num, degree)}");
