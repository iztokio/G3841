

int num = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(num);
//string value = num.ToString();
char[] digit = num.ToString().ToCharArray();
Console.WriteLine(digit);
// if(digit.Length > 3)
// {
//     Console.WriteLine(digit[2]);
// }
// else
// {
//     Console.WriteLine("Третий цифры нет");
// }    