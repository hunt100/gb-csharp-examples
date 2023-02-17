// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// A(m,n) -> n + 1, m = 0
// A(m-1, 1), m > 0, n = 0
// A(m-1, A(m, n-1)), m > 0, n > 0

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CalculateAckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    else if (m > 0 && n == 0)
    {
        return CalculateAckermannFunction(m - 1, 1);
    }
    else
    {
        return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
    }
}
int m = Prompt("Write down m:");
int n = Prompt("Write down n:");

Console.WriteLine($"M = {m}, N = {n} -> A(m,n) = {CalculateAckermannFunction(m, n)}");
