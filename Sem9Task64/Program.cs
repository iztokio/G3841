int ReadData(string message)
{
    Console.Write(message);
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        Console.Write(message);
    }
    return number;
}

void PrintResult(string message)
{
    Console.WriteLine(message);
}

string GenerateNaturalNumbers(int n)
{
    if (n == 1)
    {
        return "1";
    }
    else
    {
        return n + " " + GenerateNaturalNumbers(n - 1);
    }
}

void Main()
{
    int n = ReadData("Enter a natural number N: ");
    string resultLine = GenerateNaturalNumbers(n);
    PrintResult(resultLine);
}