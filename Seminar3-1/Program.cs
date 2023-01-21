int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateInput(int quarterPart)
{
    return quarterPart > 0 && quarterPart <= 4;
}

string GetCoordQuarter()
{
    int quarterPart = Prompt("Write down the quarterPart:");

    if (!ValidateInput(quarterPart))
    {
        throw new ArgumentException("Illegal quarter part value");
    }

    const string allPositivePart = "(0; +Inf),(0; +Inf)";
    const string xPosYNegPart = "(0; +Inf),(0; -Inf)";
    const string allNegativePart = "(0; -Inf),(0; -Inf)";
    const string xNegYPostPart = "(0; -Inf),(0; +Inf)";
    switch (quarterPart)
    {
        case 1: return allPositivePart;
        case 2: return xNegYPostPart;
        case 3: return allNegativePart;
        case 4: return xPosYNegPart;
    }

    throw new ArgumentException("Argument mismatch!");
}

Console.WriteLine($"Coordinate by quarter: {GetCoordQuarter()}");
