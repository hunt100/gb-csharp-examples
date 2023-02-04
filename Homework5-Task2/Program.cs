// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//
// [3, 7, 23, 12] -> 19
//
// [-4, -6, 89, 6] -> 0

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
        arr[i] = random.Next(1, 100);
    }
    return arr;
}

int OddPositionSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    { 
        sum += arr[i];
    }

    return sum;
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
int oddPosSum = OddPositionSum(arr);
PrintArray(arr);
Console.WriteLine($"Odd position number sum: {oddPosSum}");
