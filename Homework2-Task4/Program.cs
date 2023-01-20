// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Не использовать строки для расчета.

Console.WriteLine("Write number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"From {num} to {getNumWithoutSecondDigit(num)}");

static int getNumWithoutSecondDigit(int num)
{
    if (num < 100 || num >= 1000)
    {
        throw new ArgumentException($"Number {num} is out of range [100; 1000)! Exit....");
    }

    int tens = num / 100 * 10;
    int ones = num % 100 % 10;
    return tens + ones;
}
