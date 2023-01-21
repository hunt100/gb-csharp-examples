// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateInput(int input)
{
    return input > 0;
}

int num = Prompt("Write down N:");
if (!ValidateInput(num))
{
    throw new ArgumentException("Illegal argument of N: Not in range [1; +Inf)");
}

for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i, 2));
    Console.Write(i == num ? "." : ", ");
}
