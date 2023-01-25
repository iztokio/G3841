string? inputNum = Console.ReadLine();
if(inputNum!=null)
{
    int number = int.Parse(inputNum);
    if (number % 2 == 0)
    {
        Console.WriteLine(number + " является четным числом");
    }
    else
    {
        Console.WriteLine(number + " является НЕ четным числом");
    }
}