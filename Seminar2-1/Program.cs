// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int randNum = new Random().Next(10, 100);

int firstReminder = randNum / 10;
int secondReminder = randNum % 10;

int max = firstReminder > secondReminder ? firstReminder : secondReminder;
Console.WriteLine($"Generated number: {randNum}");
Console.WriteLine("Max: " + max);
