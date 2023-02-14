string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
if (inputNum1 != null && inputNum2 != null)
{
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    if (number1 > number2)
    {
        Console.WriteLine("число " + number1 + " больше числа " + number2);
    }
    else
    {
        Console.WriteLine("число " + number2 + " больше числа " + number1);
    }
}