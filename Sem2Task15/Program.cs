int day = int.Parse(Console.ReadLine() ?? "0");// Ввод числа
if((day > 7) || (day < 1))
{
    Console.WriteLine("Это не день не дели");
}
else
{
    if(day > 5)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}