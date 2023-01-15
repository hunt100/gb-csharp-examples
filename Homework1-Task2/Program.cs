// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
    
Console.WriteLine("Write your firstNumber: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write your secondNumber: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write your thirdNumber: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max;
if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    max = firstNumber;
} else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    max = secondNumber;
}
else
{
    max = thirdNumber;
}

Console.WriteLine($"max = {max}");