int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

bool PalinTest(int n)
{
    bool res = true;
    int d1 = n / 10000;
    int d2 = (n / 1000) % 10;
    int d4 = (n / 10) % 10;
    int d5 = n % 10;
    res = ((d1 == d5) && (d2 == d4)) ? true : false;
    return res;
}

void PrintData(string msg, bool res)
{
    Console.WriteLine(msg + res);
}

int n = ReadData("Введите число");
bool res = PalinTest(n);
PrintData($"Утверждение что число {n} палиндром, является: ", res);