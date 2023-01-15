// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Write your number: ");
int num = Convert.ToInt32(Console.ReadLine());

string isEvenMsg = num % 2 == 0 ? "yes" : "no";

Console.WriteLine($"{num} is even? {isEvenMsg}");