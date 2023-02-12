// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Random random = new Random();

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int m, int n)
{
    if (m == 0 || n == 0)
    {
        throw new ArgumentException("Illegal arguments for array size");
    }
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

int[] FindEachRowSum(int[,] arr)
{
    int[] rowSumAggregator = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rowSumAggregator[i] += arr[i, j];
        }
    }

    return rowSumAggregator;
}

int FinMinRow(int[] arr)
{
    int min = arr[0];
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            minIndex = i;
        }
    }

    return minIndex;
}

int m = Prompt("m: ");
int n = Prompt("n: ");

int[,] arr = FillArray(m, n);
PrintArray(arr);

int minIndexRow = FinMinRow(FindEachRowSum(arr));
Console.WriteLine($"Min index row: {minIndexRow}, position: {minIndexRow + 1}");
