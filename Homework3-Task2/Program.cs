// Задача 21
//
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//
// A (3,6,8); B (2,1,-7), -> 15.84
//
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double GetSegmentLength(double aX, double aY, double aZ, double bX, double bY, double bZ)
{
    double xPart = Math.Pow((bX - aX), 2);
    double yPart = Math.Pow((bY - aY), 2);
    double zPart = Math.Pow((bZ - aZ), 2);
    return Math.Sqrt(xPart + yPart + zPart);
}

double aX = Prompt("Write down A point x coordinate:");
double aY = Prompt("Write down A point y coordinate:");
double aZ = Prompt("Write down A point z coordinate:");
double bX = Prompt("Write down B point x coordinate:");
double bY = Prompt("Write down B point y coordinate:");
double bZ = Prompt("Write down B point z coordinate:");


Console.WriteLine($"A({aX}, {aY}, {aZ}); B({bX}, {bY}, {bZ})");
Console.WriteLine($"Distance of AB -> {Math.Round(GetSegmentLength(aX, aY, aZ, bX, bY, bZ), 3)}");
