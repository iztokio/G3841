// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

double[] PointFind(int k1, int b1, int k2, int b2)
{
    double[] outArr = new double[2];
    double x = (double)(b2 - b1) / (double)(k1 - k2);
    double y = k1 * x + b1;
    outArr[0] = x;
    outArr[1] = y;
    return outArr;
}

int k1 = ReadData("Введите точку k1: ");
int b1 = ReadData("Введите точку b1: ");
int k2 = ReadData("Введите точку k2: ");
int b2 = ReadData("Введите точку b2: ");

double[] Point = PointFind(k1, b1, k2, b2);

PrintData("Точка пересечения двух линий: ", $"({Point[0]};{Point[1]})");