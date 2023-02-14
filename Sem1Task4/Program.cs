string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();
if (inputNum1 != null && inputNum2 != null && inputNum3 != null)
{
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    int number3 = int.Parse(inputNum3);
    if (number1 > number2)
    {
        if (number1 > number3)
            Console.WriteLine("максимальное число " + number1);
        else
        {
            Console.WriteLine("максимальное число " + number3);
        }
    }
    else
    {
        if (number2 > number3)
            Console.WriteLine("максимальное число " + number2);
        else
        {
            Console.WriteLine("максимальное число " + number3);
        }
    }
}