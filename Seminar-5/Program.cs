// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

double Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i == arr.Length - 1)
        {
            break;
        }
        Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

double[] edgeLength = {
    Prompt("Write 1 length:"),
    Prompt("Write 2 length:"),
    Prompt("Write 3 length:")
};

bool IsTriangleExist(double[] edgeLength)
{
    for (int i = 0; i < edgeLength.Length; i++)
    {
        if (edgeLength[0] > edgeLength[1] + edgeLength[2])
        {
            return false;
        }

        edgeLength = edgeLength.Skip(1).Concat(edgeLength.Take(1)).ToArray();
    }

    return true;
}

PrintArray(edgeLength);
bool isValid = IsTriangleExist(edgeLength);
Console.WriteLine($"is valid triangle: {isValid}");
