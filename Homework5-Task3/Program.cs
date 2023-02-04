// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//
// [3 7 22 2 78] -> 76

Random random = new Random();

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] CreateArray(int size)
{
    int lowBound = 1;
    int upBound = 100;
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(random.NextDouble() * (upBound - lowBound) + lowBound, 3);
    }
    return arr;
}

double[] GetExtremumNumbers(double[] arr)
{
    double[] extremumNumbers = new double[2];
    if (arr.Length == 0)
    {
        return extremumNumbers;
    }

    double min = arr[0];
    double max = arr[0];
    foreach (double num in arr)
    {
        if (num < min)
        {
            min = num;
        }

        if (num > max)
        {
            max = num;
        }
    }

    extremumNumbers[0] = min;
    extremumNumbers[1] = max;
    return extremumNumbers;
}

void PrintArray(double[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i == arr.Length - 1)
        {
            break;
        }
        Console.Write("; ");
    }
    Console.Write(" ]");
    Console.WriteLine();
}

int size = Prompt("Write size of array:");
double[] arr = CreateArray(size);
PrintArray(arr);
double[] extremumNumbers = GetExtremumNumbers(arr);
Console.WriteLine($"Max: [{extremumNumbers[1]}] - Min: [{extremumNumbers[0]}] -> ${Math.Round(extremumNumbers[1] - extremumNumbers[0], 3)}");
