// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

// y = ax + c
// y = bx + d
double[] GetIntersectionCoord(double a, double c, double b, double d)
{
    bool isDegreeCoefEqual = IsEqual(a, b);
    bool isOffsetCoefEqual = IsEqual(c, d);
    if (isDegreeCoefEqual)
    {
        if (isDegreeCoefEqual)
        {
            if (isOffsetCoefEqual)
            {
                throw new ArgumentException("There is no single point of intersection, lines are identical.");
            }

            throw new ArgumentException("There is no single point of intersection, lines are parallel.");
        }
    }
    double[] coord = new double[2];
    coord[0] = (d - c) / (a - b);
    coord[1] = a * (d - c) / (a - b) + c;
    return coord;
}

bool IsEqual(double first, double second)
{
    return Math.Abs(first - second) < .0001;
}


double b1 = Prompt("Write b1");
double k1 = Prompt("Write k1");
double b2 = Prompt("Write b2");
double k2 = Prompt("Write k2");
double[] coord = GetIntersectionCoord(k1, b1, k2, b2);
Console.WriteLine($"({coord[0]}; {coord[1]})");
