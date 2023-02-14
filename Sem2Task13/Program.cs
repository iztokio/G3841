//int num1 = int.Parse(Console.ReadLine()??"0");
char[] digit = (Console.ReadLine() ?? "0").ToCharArray();
if (digit.Length >= 3)
{
    Console.WriteLine(digit[2]);
}
else
{
    Console.WriteLine("Третий цифры нет");
}