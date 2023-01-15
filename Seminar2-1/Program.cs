// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Input first num: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second num: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(firstNum % secondNum == 0
    ? "Division without reminder"
    : $"Division with reminder! Reminder: {firstNum % secondNum}");