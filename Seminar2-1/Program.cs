// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = num % 7 == 0 && num % 23 == 0;
Console.WriteLine($"Input value: {num}. Is division on 7 and 23 is without reminder? {result}");