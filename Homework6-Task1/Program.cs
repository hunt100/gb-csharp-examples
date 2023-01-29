// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

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
        arr[i] = Prompt($"Write {i} number of arr:");
    }

    return arr;
}

int GetPositiveNumbers(int[] arr)
{
    int count = 0;
    foreach (int num in arr)
    {
        if (num > 0)
        {
            count++;
        }
    }

    return count;
}

void PrintArray(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

int size = Prompt("Write size of arr:");
int[] arr = FillArray(size);
PrintArray(arr);
Console.WriteLine($"Count of positive numbers: {GetPositiveNumbers(arr)}");
