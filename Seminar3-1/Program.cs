// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)^2 + (yb - ya)^2
double Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double GetSegmentLength(double aX, double aY, double bX, double bY)
{
    double leftPart = Math.Pow((bX - aX), 2);
    double rightPart = Math.Pow((bY - aY), 2);
    return Math.Sqrt(leftPart + rightPart);
}

double aX = Prompt("Write down A point x coordinate:");
double aY = Prompt("Write down A point y coordinate:");
double bX = Prompt("Write down B point x coordinate:");
double bY = Prompt("Write down B point y coordinate:");

Console.WriteLine($"A({aX}, {aY}); B({bX}, {bY})");
Console.WriteLine($"Distance of AB -> {Math.Round(GetSegmentLength(aX, aY, bX, bY), 3)}");
