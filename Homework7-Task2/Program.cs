// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//
// Например, задан массив:
//
// 1 4 7 2
//
// 5 9 2 3
//
// 8 4 2 4
//
// 17 -> такого числа в массиве нет

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

int FindElement(int rowPos, int colPos, int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int colSize = arr.GetLength(1);
    int rIndex = rowPos - 1;
    int cIndex = colPos - 1;
    if (ValidateInput(rIndex, cIndex, rowSize, colSize))
    {
        return arr[rIndex, cIndex];
    }

    throw new ArgumentException("There is no number with pos [" + rowPos + ", " + colPos + "]");
}

bool ValidateInput(int rowPos, int colPos, int rowSize, int colSize)
{
    return (rowPos >= 0 && rowPos < rowSize) && (colPos >= 0 && colPos < colSize);
}

int m = Prompt("Write m:");
int n = Prompt("Write n:");

int[,] arr = FillArray(m, n);
PrintArray(arr);
int rowPos = Prompt("rowPos: ");
int colPos = Prompt("colPos: ");

Console.WriteLine($"Found number: {FindElement(rowPos, colPos, arr)}");
