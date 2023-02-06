// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 100);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
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

void CalculateAvgInColumn(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double count = 0.0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            count += arr[j, i];
        }

        count /= arr.GetLength(0);
        Console.Write($"{Math.Round(count, 2)}; \t");
    }
}

int m = Prompt("Write m:");
int n = Prompt("Write n:");

int[,] arr = FillArray(m, n);
PrintArray(arr);
CalculateAvgInColumn(arr);
