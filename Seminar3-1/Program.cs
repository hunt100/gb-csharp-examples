int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateInput(int x, int y)
{
    return x != 0 && y != 0;
}

int GetCoordQuarter()
{
    int x = Prompt("Write down the x coord:");
    int y = Prompt("Write down the y coord:");

    if (!ValidateInput(x, y))
    {
        throw new ArgumentException("Illegal coordinates value");
    }
    
    // 1 && 1 = 1
    // 1 && -1 = 4
    // -1 && -1 = 3
    // -1 && 1 = 2

    if (x > 0)
    {
        return y > 0 ? 1 : 4;
    }

    return y > 0 ? 2 : 3;
}

Console.WriteLine($"Coordinate quarter: {GetCoordQuarter()}");





