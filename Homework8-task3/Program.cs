// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            arr[i, j] = random.Next(0, 20);
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

int[,] Multiply(int[,] matrixA, int[,] matrixB)
{
    if (!IsConsistentMatrices(matrixA, matrixB))
    {
        throw new ArgumentException("Matrix A m size not equal Matrix B n size, can not multiply");
    }

    int m = matrixA.GetLength(0);
    int n = matrixB.GetLength(1);
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return result;
}

bool IsConsistentMatrices(int[,] matrixA, int[,] matrixB)
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}

int Am = Prompt("Am: ");
int An = Prompt("An: ");

int[,] matrixA = FillArray(Am, An);

Console.WriteLine();
PrintArray(matrixA);
Console.WriteLine();

int Bm = Prompt("Bm: ");
int Bn = Prompt("Bn: ");

int[,] matrixB = FillArray(Bm, Bn);

Console.WriteLine();
PrintArray(matrixB);

int[,] result = Multiply(matrixA, matrixB);
Console.WriteLine("\nResult:");
PrintArray(result);
