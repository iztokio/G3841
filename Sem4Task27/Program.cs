// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.Write(msg1);
    Console.Write(msg2);
}

int SumSym(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

int a = ReadData("Введите число ");

int res = SumSym(a);

PrintData($"Сумма составных чисел, числа {a} равна: ", res);