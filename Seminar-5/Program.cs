// Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Random random = new Random();

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 10);
    }
    return arr;
}

void Clone(int[] from, int[] where)
{
    for (int i = 0; i < from.Length; i++)
    {
        where[i] = from[i];
    }    
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int arrASize = Prompt("Write down size of arr a:");
int[] a = FillArray(arrASize);
int[] b = new int[a.Length];
Clone(a, b);
PrintArray(a);
Console.WriteLine();
PrintArray(b);
Console.WriteLine();
a[0] = 1337;
PrintArray(a);
Console.WriteLine();
PrintArray(b);
Console.WriteLine();