// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//
// [345, 897, 568, 234] -> 2

Random random = new Random();

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
}

int CountEvenNumbers(int[] arr)
{
    int counter = 0;
    foreach (int num in arr)
    {
        if (num % 2 == 0)
        {
            counter++;
        }
    }

    return counter;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i == arr.Length - 1)
        {
            break;
        }
        Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int size = Prompt("Write size of array:");
int[] arr = CreateArray(size);
int evenNumberCount = CountEvenNumbers(arr);
PrintArray(arr);
Console.WriteLine($"Even number count: {evenNumberCount}");
