// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Усложнение: в промежутке от и до, задаваемый размер
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Random random = new Random();

double Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

double[] FillArray(int arrayLength, double lowBound, double upBound)
{
    double[] arr = new double[arrayLength];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(random.NextDouble() * (upBound - lowBound) + lowBound, 3);
    }

    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int arrayLength = (int)Prompt("Write down number of elements in array:");
double lowBound = Prompt("Write down the lower bound:");
double upBound = Prompt("Write down the upper bound:");

PrintArray(FillArray(arrayLength, lowBound, upBound));
