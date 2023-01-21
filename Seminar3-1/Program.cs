// Напишите программу, которая генерирует последовательность случайных чисел из 10 элементов в диапазоне от 1 до 10,
// и подсчитывает, сколько сгенерировалось чисел больше 5.
Random random = new Random();

int counter = 0;
for (int i = 0; i < 10; i++)
{
    int nextInt = random.Next(1, 11);
    if (nextInt > 5)
    {
        counter++;
    }
    Console.Write(nextInt + " ");
}
Console.WriteLine();
Console.WriteLine($"Numbers more than 5: {counter}");
