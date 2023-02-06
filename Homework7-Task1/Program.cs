// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
// m = 3, n = 4.
//
// 0,5 7 -2 -0,2
//
// 1 -3,3 8 -9,9
//
// 8 7,8 -7,1 9

Random random = new Random();

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillArray(int m, int n)
{
    double[,] arr = new double[m, n];
    int lowBound = -100;
    int upBound = 100;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(random.NextDouble() * (upBound - lowBound) + lowBound, 2);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int m = Prompt("Write m:");
int n = Prompt("Write n:");

PrintArray(FillArray(m, n));
